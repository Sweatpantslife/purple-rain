using UnityEngine;
using UnityEngine.Events;

namespace PurpleRain.Interaction
{
    /// <summary>
    /// Convenience base class for scene interactables: serialized verb, display
    /// name, a lock flag (for content gated behind puzzle state) and hover /
    /// interact UnityEvents for designer wiring.
    /// Requires a collider (any type, non-trigger) on the same object or a child
    /// so the <see cref="Interactor"/> raycast can find it.
    /// </summary>
    public abstract class InteractableBase : MonoBehaviour, IInteractable
    {
        [Header("Interactable")]
        [SerializeField] private InteractionVerb verb = InteractionVerb.Examine;
        [SerializeField] private string displayName = "Object";
        [SerializeField] private bool locked;

        [Header("Events")]
        [SerializeField] private UnityEvent onHoverEnter;
        [SerializeField] private UnityEvent onHoverExit;
        [SerializeField] private UnityEvent onInteracted;

        public virtual InteractionVerb Verb => verb;
        public virtual string DisplayName => displayName;
        public bool IsLocked => locked;

        public virtual bool CanInteract(Interactor interactor)
        {
            return !locked && isActiveAndEnabled;
        }

        /// <summary>Lock/unlock this interactable (e.g. from LeachateWallReveal via UnityEvent).</summary>
        public void SetLocked(bool value)
        {
            locked = value;
        }

        public virtual void OnHoverEnter(Interactor interactor)
        {
            onHoverEnter?.Invoke();
        }

        public virtual void OnHoverExit(Interactor interactor)
        {
            onHoverExit?.Invoke();
        }

        public void Interact(Interactor interactor)
        {
            if (!CanInteract(interactor))
            {
                return;
            }

            OnInteract(interactor);
            onInteracted?.Invoke();
        }

        protected abstract void OnInteract(Interactor interactor);
    }
}
