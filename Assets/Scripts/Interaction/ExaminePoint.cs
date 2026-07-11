using UnityEngine;
using UnityEngine.Events;
using PurpleRain.Core;
using PurpleRain.Evidence;

namespace PurpleRain.Interaction
{
    /// <summary>
    /// An examinable detail in the world — the slice's stand-in for Water Reading
    /// observations (flow direction, sediment fans, datum lines; GAMEPLAY.md
    /// §2.3.2). On interact it emits its examine text (wire
    /// <see cref="onExamined"/> to HudMessageUI.Show), optionally logs an
    /// observation into the journal, and optionally raises a story beat.
    /// </summary>
    public sealed class ExaminePoint : InteractableBase
    {
        [Header("Examine")]
        [SerializeField, TextArea(2, 6)] private string examineText = "";
        [SerializeField] private bool lockAfterUse;

        [Header("Optional journal entry")]
        [SerializeField] private EvidenceItem logAsEvidence;

        [Header("Optional story beat")]
        [SerializeField] private StoryBeatChannel beatChannel;
        [SerializeField] private StoryBeat raiseBeat;

        [Header("Examine hooks")]
        [SerializeField] private UnityEvent<string> onExamined;

        protected override void OnInteract(Interactor interactor)
        {
            onExamined?.Invoke(examineText);

            if (logAsEvidence != null)
            {
                EvidenceJournal journal = EvidenceJournal.Instance;
                if (journal != null)
                {
                    journal.Add(logAsEvidence);
                }
            }

            if (beatChannel != null && raiseBeat != null)
            {
                beatChannel.Raise(raiseBeat);
            }

            if (lockAfterUse)
            {
                SetLocked(true);
            }
        }
    }
}
