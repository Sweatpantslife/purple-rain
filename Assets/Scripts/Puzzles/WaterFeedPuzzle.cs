using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using PurpleRain.Core;

namespace PurpleRain.Puzzles
{
    /// <summary>
    /// P-A2-S03-1 "The Name Trade" — the Undercroft feed (docs/gameplay/PUZZLES.md).
    /// Hydraulic Routing, state-based and order-free: the puzzle solves when every
    /// listed valve matches its required state (close the fouled leg, open the
    /// bypass and distribution main, close the relief drain to re-pressurize).
    /// Multiple valid orders reach the same isolation — no single-solution trap,
    /// and per canon there are no fail states: wrong states simply report progress.
    /// On solve it latches, fires <see cref="onSolved"/>/<see cref="Solved"/> and
    /// raises the configured story beat (R0 begins).
    /// </summary>
    public sealed class WaterFeedPuzzle : MonoBehaviour
    {
        [Serializable]
        public sealed class ValveRequirement
        {
            public ValveInteractable valve;
            public bool mustBeOpen;
        }

        [Header("Solution (state-based, order-free)")]
        [SerializeField] private List<ValveRequirement> requirements = new List<ValveRequirement>();

        [Header("Story beat on solve (optional)")]
        [SerializeField] private StoryBeatChannel beatChannel;
        [SerializeField] private StoryBeat solvedBeat;

        [Header("Puzzle hooks")]
        [SerializeField] private UnityEvent onSolved;
        [SerializeField] private UnityEvent<int, int> onProgressChanged;

        public bool IsSolved { get; private set; }

        /// <summary>Fired once, when the network first reaches the solved state.</summary>
        public event Action Solved;

        private void OnEnable()
        {
            foreach (ValveRequirement requirement in requirements)
            {
                if (requirement != null && requirement.valve != null)
                {
                    requirement.valve.StateChanged += HandleValveChanged;
                }
            }
        }

        private void OnDisable()
        {
            foreach (ValveRequirement requirement in requirements)
            {
                if (requirement != null && requirement.valve != null)
                {
                    requirement.valve.StateChanged -= HandleValveChanged;
                }
            }
        }

        private void Start()
        {
            Evaluate();
        }

        private void HandleValveChanged(ValveInteractable valve)
        {
            Evaluate();
        }

        private void Evaluate()
        {
            if (IsSolved)
            {
                return;
            }

            int total = 0;
            int satisfied = 0;
            foreach (ValveRequirement requirement in requirements)
            {
                if (requirement == null || requirement.valve == null)
                {
                    continue;
                }
                total++;
                if (requirement.valve.IsOpen == requirement.mustBeOpen)
                {
                    satisfied++;
                }
            }

            onProgressChanged?.Invoke(satisfied, total);

            if (total > 0 && satisfied == total)
            {
                IsSolved = true;
                Solved?.Invoke();
                onSolved?.Invoke();
                if (beatChannel != null && solvedBeat != null)
                {
                    beatChannel.Raise(solvedBeat);
                }
            }
        }
    }
}
