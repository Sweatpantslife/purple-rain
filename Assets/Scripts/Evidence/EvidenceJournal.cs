using System;
using System.Collections.Generic;
using UnityEngine;

namespace PurpleRain.Evidence
{
    /// <summary>
    /// Runtime evidence journal service (Field Notebook stub) — MonoBehaviour
    /// singleton. Stores collected <see cref="EvidenceItem"/>s and raises C# events
    /// for UI and future systems (Evidence Board, save/load).
    /// Place exactly one instance in the scene (e.g. on a "Systems" object).
    /// </summary>
    public sealed class EvidenceJournal : MonoBehaviour
    {
        public static EvidenceJournal Instance { get; private set; }

        private readonly List<EvidenceItem> entries = new List<EvidenceItem>();

        public IReadOnlyList<EvidenceItem> Entries => entries;
        public int Count => entries.Count;

        /// <summary>Fired once per newly collected item.</summary>
        public event Action<EvidenceItem> EvidenceAdded;

        /// <summary>Fired on any change to the collection.</summary>
        public event Action JournalChanged;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Debug.LogWarning("EvidenceJournal: duplicate instance destroyed.", this);
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }

        private void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }

        /// <summary>Adds an item if not already collected. Returns true when newly added.</summary>
        public bool Add(EvidenceItem item)
        {
            if (item == null || entries.Contains(item))
            {
                return false;
            }

            entries.Add(item);
            EvidenceAdded?.Invoke(item);
            JournalChanged?.Invoke();
            return true;
        }

        public bool Contains(EvidenceItem item)
        {
            return item != null && entries.Contains(item);
        }
    }
}
