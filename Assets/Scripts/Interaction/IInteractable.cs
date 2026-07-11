namespace PurpleRain.Interaction
{
    /// <summary>
    /// Contract for anything the player can focus and interact with via the
    /// raycast <see cref="Interactor"/>.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>Which verb the prompt shows (Examine / Take / Use).</summary>
        InteractionVerb Verb { get; }

        /// <summary>Human-readable name shown in the hover prompt.</summary>
        string DisplayName { get; }

        /// <summary>Whether this target currently accepts interaction (unlocked, active).</summary>
        bool CanInteract(Interactor interactor);

        /// <summary>Called when the interactor's focus enters this target.</summary>
        void OnHoverEnter(Interactor interactor);

        /// <summary>Called when the interactor's focus leaves this target.</summary>
        void OnHoverExit(Interactor interactor);

        /// <summary>Performs the interaction.</summary>
        void Interact(Interactor interactor);
    }
}
