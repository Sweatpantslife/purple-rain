using UnityEngine;
using UnityEngine.Events;
using PurpleRain.Interaction;

namespace PurpleRain.Puzzles
{
    /// <summary>
    /// The A2-S03 reveal: "the puzzle's final valve turn re-lights the chamber and
    /// reveals the wall staged like an altar" (LOCATIONS.md, LOC-undercroft).
    /// Subscribes to <see cref="WaterFeedPuzzle.Solved"/> and, on solve:
    /// enables the reveal set (violet lights, leachate sheet), disables the
    /// blocking set (the jammed grate), and unlocks gated interactables
    /// (the sample pickup). Idempotent; can also be driven manually via
    /// <see cref="Reveal"/> from a UnityEvent.
    /// </summary>
    public sealed class LeachateWallReveal : MonoBehaviour
    {
        [SerializeField] private WaterFeedPuzzle puzzle;

        [Header("Reveal set")]
        [SerializeField] private GameObject[] enableOnReveal;
        [SerializeField] private GameObject[] disableOnReveal;
        [SerializeField] private InteractableBase[] unlockOnReveal;

        [Header("Options")]
        [SerializeField] private bool lockTargetsOnStart = true;

        [Header("Reveal hooks")]
        [SerializeField] private UnityEvent onRevealed;

        private bool revealed;

        private void OnEnable()
        {
            if (puzzle != null)
            {
                puzzle.Solved += Reveal;
            }
        }

        private void OnDisable()
        {
            if (puzzle != null)
            {
                puzzle.Solved -= Reveal;
            }
        }

        private void Start()
        {
            if (revealed || !lockTargetsOnStart || unlockOnReveal == null)
            {
                return;
            }
            foreach (InteractableBase interactable in unlockOnReveal)
            {
                if (interactable != null)
                {
                    interactable.SetLocked(true);
                }
            }
        }

        public void Reveal()
        {
            if (revealed)
            {
                return;
            }
            revealed = true;

            if (enableOnReveal != null)
            {
                foreach (GameObject target in enableOnReveal)
                {
                    if (target != null)
                    {
                        target.SetActive(true);
                    }
                }
            }

            if (disableOnReveal != null)
            {
                foreach (GameObject target in disableOnReveal)
                {
                    if (target != null)
                    {
                        target.SetActive(false);
                    }
                }
            }

            if (unlockOnReveal != null)
            {
                foreach (InteractableBase interactable in unlockOnReveal)
                {
                    if (interactable != null)
                    {
                        interactable.SetLocked(false);
                    }
                }
            }

            onRevealed?.Invoke();
        }
    }
}
