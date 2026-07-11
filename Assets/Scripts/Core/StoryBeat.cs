using UnityEngine;

namespace PurpleRain.Core
{
    /// <summary>
    /// A single authored story beat (e.g. "the feed is restored, R0 begins").
    /// Data only; raised through a <see cref="StoryBeatChannel"/>.
    /// Beat ids should reference canonical doc ids (scene, clue, reveal) where possible.
    /// </summary>
    [CreateAssetMenu(menuName = "Purple Rain/Story Beat", fileName = "BEAT-NewBeat")]
    public sealed class StoryBeat : ScriptableObject
    {
        [SerializeField] private string beatId = "BEAT-XX";
        [SerializeField] private string title = "New Beat";
        [SerializeField, TextArea(2, 6)] private string description = "";

        public string BeatId => beatId;
        public string Title => title;
        public string Description => description;
    }
}
