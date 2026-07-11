using UnityEngine;
using UnityEngine.Events;

namespace PurpleRain.Core
{
    /// <summary>
    /// Generic trigger volume: fires a UnityEvent (and optionally a story beat)
    /// when an object with the required tag enters.
    /// The CharacterController on the player generates the trigger contact; make
    /// sure the player root is tagged "Player" and this collider is set to Is Trigger.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public sealed class TriggerVolume : MonoBehaviour
    {
        [SerializeField] private string requiredTag = "Player";
        [SerializeField] private bool triggerOnce = true;
        [SerializeField] private StoryBeatChannel beatChannel;
        [SerializeField] private StoryBeat beat;
        [SerializeField] private UnityEvent onEntered;

        private bool hasTriggered;

        private void Reset()
        {
            Collider volume = GetComponent<Collider>();
            if (volume != null)
            {
                volume.isTrigger = true;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (hasTriggered && triggerOnce)
            {
                return;
            }
            if (!string.IsNullOrEmpty(requiredTag) && !other.CompareTag(requiredTag))
            {
                return;
            }

            hasTriggered = true;
            onEntered?.Invoke();
            if (beatChannel != null && beat != null)
            {
                beatChannel.Raise(beat);
            }
        }

        public void ResetTrigger()
        {
            hasTriggered = false;
        }
    }
}
