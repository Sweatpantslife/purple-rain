using UnityEngine;

namespace PurpleRain.Evidence
{
    /// <summary>Coarse evidence categories for the journal stub.</summary>
    public enum EvidenceCategory
    {
        Document = 0,
        Sample = 1,
        Photograph = 2,
        Observation = 3,
        PhysicalObject = 4
    }

    /// <summary>
    /// Provenance is systemic in Purple Rain (GAMEPLAY.md §2.3, guardrail §8.4):
    /// every evidence item records where it came from. The journal stub carries the
    /// three canonical buckets from day one so C-25's "unsourced" mechanic has a
    /// data home when the Evidence Board arrives.
    /// </summary>
    public enum EvidenceProvenance
    {
        SurfaceSourced = 0,
        BelowSourced = 1,
        Unsourced = 2
    }

    /// <summary>
    /// A collectible clue definition. Ids should cite canonical doc ids
    /// (e.g. "EV-A2S03-SAMPLE", with C-##/R# references in the description).
    /// </summary>
    [CreateAssetMenu(menuName = "Purple Rain/Evidence Item", fileName = "EV-NewEvidence")]
    public sealed class EvidenceItem : ScriptableObject
    {
        [SerializeField] private string id = "EV-XX";
        [SerializeField] private string title = "New Evidence";
        [SerializeField, TextArea(2, 6)] private string description = "";
        [SerializeField] private EvidenceCategory category = EvidenceCategory.Observation;
        [SerializeField] private EvidenceProvenance provenance = EvidenceProvenance.BelowSourced;
        [SerializeField] private Sprite icon;

        public string Id => id;
        public string Title => title;
        public string Description => description;
        public EvidenceCategory Category => category;
        public EvidenceProvenance Provenance => provenance;
        public Sprite Icon => icon;
    }
}
