using System;
using UnityEngine;

namespace PurpleRain.Core
{
    /// <summary>
    /// ScriptableObject event channel for story beats.
    /// Gameplay raises beats on a shared channel asset; listeners (UI, sequencing,
    /// future quest logic) subscribe without direct scene references.
    /// </summary>
    [CreateAssetMenu(menuName = "Purple Rain/Story Beat Channel", fileName = "SBC-Main")]
    public sealed class StoryBeatChannel : ScriptableObject
    {
        [SerializeField] private bool logToConsole = true;

        public event Action<StoryBeat> BeatRaised;

        public void Raise(StoryBeat beat)
        {
            if (beat == null)
            {
                Debug.LogWarning($"StoryBeatChannel '{name}': Raise called with a null beat.", this);
                return;
            }

            if (logToConsole)
            {
                Debug.Log($"[StoryBeat] {beat.BeatId} — {beat.Title}", beat);
            }

            BeatRaised?.Invoke(beat);
        }
    }
}
