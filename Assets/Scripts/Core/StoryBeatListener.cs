using UnityEngine;
using UnityEngine.Events;

namespace PurpleRain.Core
{
    /// <summary>
    /// Scene-side listener for a <see cref="StoryBeatChannel"/>.
    /// If <see cref="filterBeat"/> is assigned, only that beat fires the events;
    /// otherwise every beat on the channel does.
    /// Wire <see cref="onBeatText"/> to a HUD text sink (e.g. HudMessageUI.Show)
    /// for a zero-code debug readout of story progression.
    /// </summary>
    public sealed class StoryBeatListener : MonoBehaviour
    {
        [SerializeField] private StoryBeatChannel channel;
        [SerializeField] private StoryBeat filterBeat;
        [SerializeField] private UnityEvent<string> onBeatText;
        [SerializeField] private UnityEvent onBeat;

        private void OnEnable()
        {
            if (channel != null)
            {
                channel.BeatRaised += HandleBeatRaised;
            }
        }

        private void OnDisable()
        {
            if (channel != null)
            {
                channel.BeatRaised -= HandleBeatRaised;
            }
        }

        private void HandleBeatRaised(StoryBeat beat)
        {
            if (beat == null)
            {
                return;
            }
            if (filterBeat != null && beat != filterBeat)
            {
                return;
            }

            onBeatText?.Invoke($"{beat.BeatId} — {beat.Title}");
            onBeat?.Invoke();
        }
    }
}
