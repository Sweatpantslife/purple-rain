using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using PurpleRain.Core;

namespace PurpleRain.Interaction
{
    /// <summary>
    /// Raycast-based interaction driver. Casts from <see cref="rayOrigin"/>
    /// (normally the camera pivot) every frame, tracks the focused
    /// <see cref="IInteractable"/>, raises hover/focus events, and performs the
    /// interaction when the Interact action is pressed.
    ///
    /// UI can bind either to the C# events (<see cref="FocusChanged"/>,
    /// <see cref="PromptChanged"/>) or to the serialized UnityEvents.
    /// </summary>
    public sealed class Interactor : MonoBehaviour
    {
        [Header("Input")]
        [SerializeField] private InputActionsProvider input;

        [Header("Raycast")]
        [SerializeField] private Transform rayOrigin;
        [SerializeField] private float interactionRange = 3f;
        [SerializeField] private LayerMask interactionLayers = ~0;

        [Header("Prompt hooks (UI can bind here instead of the C# events)")]
        [SerializeField] private UnityEvent<string> onPromptShown;
        [SerializeField] private UnityEvent onPromptHidden;

        private InputAction interactAction;
        private IInteractable current;

        public IInteractable Current => current;

        /// <summary>Fired whenever the focused interactable changes (null = nothing focused).</summary>
        public event Action<IInteractable> FocusChanged;

        /// <summary>Fired with the formatted prompt string, or null when the prompt should hide.</summary>
        public event Action<string> PromptChanged;

        private void OnEnable()
        {
            if (input != null)
            {
                interactAction = input.GetAction("Interact");
            }
            else
            {
                Debug.LogError("Interactor: no InputActionsProvider assigned.", this);
            }
        }

        private void OnDisable()
        {
            SetFocus(null);
        }

        private void Update()
        {
            UpdateFocus();

            if (current != null
                && interactAction != null
                && interactAction.WasPressedThisFrame()
                && current.CanInteract(this))
            {
                current.Interact(this);
                RefreshPrompt(); // display names may change after interaction (e.g. valve state)
            }
        }

        private void UpdateFocus()
        {
            IInteractable next = null;
            Transform origin = rayOrigin != null ? rayOrigin : transform;

            if (Physics.Raycast(
                    origin.position,
                    origin.forward,
                    out RaycastHit hit,
                    interactionRange,
                    interactionLayers,
                    QueryTriggerInteraction.Ignore))
            {
                IInteractable candidate = hit.collider.GetComponentInParent<IInteractable>();
                if (candidate != null && candidate.CanInteract(this))
                {
                    next = candidate;
                }
            }

            if (!ReferenceEquals(next, current))
            {
                SetFocus(next);
            }
        }

        private void SetFocus(IInteractable next)
        {
            if (current != null && IsAlive(current))
            {
                current.OnHoverExit(this);
            }

            current = next;

            if (current != null)
            {
                current.OnHoverEnter(this);
            }

            FocusChanged?.Invoke(current);
            RefreshPrompt();
        }

        private void RefreshPrompt()
        {
            if (current == null || !IsAlive(current))
            {
                PromptChanged?.Invoke(null);
                onPromptHidden?.Invoke();
                return;
            }

            string key = interactAction != null ? interactAction.GetBindingDisplayString() : "E";
            string prompt = $"[{key}] {VerbLabel(current.Verb)}: {current.DisplayName}";
            PromptChanged?.Invoke(prompt);
            onPromptShown?.Invoke(prompt);
        }

        private static bool IsAlive(IInteractable interactable)
        {
            if (interactable == null)
            {
                return false;
            }

            // Interactables are normally components; a destroyed component keeps a
            // managed reference but compares equal to null via Unity's operator.
            var component = interactable as Component;
            if (component != null)
            {
                return true;
            }

            // component is null here: either destroyed (was a Component) or the
            // implementer is not a Component at all (plain C# object — alive).
            return !(interactable is Component);
        }

        private static string VerbLabel(InteractionVerb verb)
        {
            switch (verb)
            {
                case InteractionVerb.PickUp:
                    return "Take";
                case InteractionVerb.Use:
                    return "Use";
                default:
                    return "Examine";
            }
        }
    }
}
