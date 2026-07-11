using UnityEngine;
using UnityEngine.Events;
using PurpleRain.Core;
using PurpleRain.Interaction;

namespace PurpleRain.Evidence
{
    /// <summary>
    /// A collectible clue in the world. On interact it logs its
    /// <see cref="EvidenceItem"/> into the <see cref="EvidenceJournal"/>, optionally
    /// raises a story beat, and (by default) deactivates itself.
    /// Use SetLocked(true) + LeachateWallReveal (or any UnityEvent) to gate pickups
    /// behind puzzle state.
    /// </summary>
    public sealed class EvidencePickup : InteractableBase
    {
        [Header("Evidence")]
        [SerializeField] private EvidenceItem item;
        [SerializeField] private bool deactivateOnPickup = true;

        [Header("Story beat (optional)")]
        [SerializeField] private StoryBeatChannel beatChannel;
        [SerializeField] private StoryBeat collectedBeat;

        [Header("Pickup hooks")]
        [SerializeField] private UnityEvent<string> onCollectedMessage;

        public EvidenceItem Item => item;

        public override InteractionVerb Verb => InteractionVerb.PickUp;

        public override string DisplayName => item != null ? item.Title : base.DisplayName;

        protected override void OnInteract(Interactor interactor)
        {
            if (item == null)
            {
                Debug.LogWarning("EvidencePickup: no EvidenceItem assigned.", this);
                return;
            }

            EvidenceJournal journal = EvidenceJournal.Instance;
            if (journal == null)
            {
                Debug.LogWarning("EvidencePickup: no EvidenceJournal in scene.", this);
                return;
            }

            if (!journal.Add(item))
            {
                return;
            }

            onCollectedMessage?.Invoke($"Logged in notebook #42: {item.Title}");

            if (beatChannel != null && collectedBeat != null)
            {
                beatChannel.Raise(collectedBeat);
            }

            if (deactivateOnPickup)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
