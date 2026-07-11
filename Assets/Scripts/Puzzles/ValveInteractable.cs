using System;
using UnityEngine;
using UnityEngine.Events;
using PurpleRain.Interaction;

namespace PurpleRain.Puzzles
{
    /// <summary>
    /// A valve the player can open/close with the Use verb — the atomic element of
    /// the Hydraulic Routing puzzle grammar (GAMEPLAY.md §7). The prompt shows the
    /// live state; an optional handle transform turns to match.
    /// State changes are broadcast through <see cref="StateChanged"/> for
    /// <see cref="WaterFeedPuzzle"/> and through a UnityEvent for scene wiring.
    /// </summary>
    public sealed class ValveInteractable : InteractableBase
    {
        [Header("Valve")]
        [SerializeField] private string valveName = "Valve";
        [SerializeField] private bool isOpen;

        [Header("Handle visual (optional)")]
        [SerializeField] private Transform handle;
        [SerializeField] private float openAngle = 120f;
        [SerializeField] private float handleTurnSpeed = 180f;

        [Header("Valve hooks")]
        [SerializeField] private UnityEvent<bool> onStateChanged;

        /// <summary>Fired after the open/closed state flips.</summary>
        public event Action<ValveInteractable> StateChanged;

        private Quaternion handleRestRotation = Quaternion.identity;

        public bool IsOpen => isOpen;
        public string ValveName => valveName;

        public override InteractionVerb Verb => InteractionVerb.Use;

        public override string DisplayName => $"{valveName} — {(isOpen ? "OPEN" : "CLOSED")}";

        private void Awake()
        {
            if (handle != null)
            {
                // Treat the authored handle pose as matching the starting state, so
                // scene-authored wheel orientations (e.g. rotated to face the room)
                // are preserved and the open/close turn composes on top of them.
                // The turn is about local Y — a Unity Cylinder's axle — so the wheel
                // spins in its disc plane instead of tipping out of it.
                Quaternion startOffset = Quaternion.Euler(0f, isOpen ? openAngle : 0f, 0f);
                handleRestRotation = handle.localRotation * Quaternion.Inverse(startOffset);
            }
        }

        protected override void OnInteract(Interactor interactor)
        {
            SetOpen(!isOpen);
        }

        public void SetOpen(bool open)
        {
            if (isOpen == open)
            {
                return;
            }

            isOpen = open;
            StateChanged?.Invoke(this);
            onStateChanged?.Invoke(isOpen);
        }

        private void Update()
        {
            if (handle == null)
            {
                return;
            }

            Quaternion target = handleRestRotation * Quaternion.Euler(0f, isOpen ? openAngle : 0f, 0f);
            handle.localRotation = Quaternion.RotateTowards(handle.localRotation, target, handleTurnSpeed * Time.deltaTime);
        }
    }
}
