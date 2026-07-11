using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using PurpleRain.Core;
using PurpleRain.Evidence;

namespace PurpleRain.UI
{
    /// <summary>
    /// Debug journal list (Field Notebook stand-in): toggled by the ToggleJournal
    /// action, populates one uGUI Text per collected evidence item.
    /// If <see cref="entryTemplate"/> is not assigned, entries are created at
    /// runtime with the built-in LegacyRuntime font.
    /// </summary>
    public sealed class EvidenceJournalUI : MonoBehaviour
    {
        [Header("Input")]
        [SerializeField] private InputActionsProvider input;

        [Header("UI")]
        [SerializeField] private GameObject panelRoot;
        [SerializeField] private RectTransform contentParent;
        [SerializeField] private Text entryTemplate;
        [SerializeField] private int runtimeFontSize = 14;

        private InputAction toggleAction;
        private EvidenceJournal subscribedJournal;
        private readonly List<GameObject> spawnedEntries = new List<GameObject>();
        private bool dirty = true;

        private void OnEnable()
        {
            if (input != null)
            {
                toggleAction = input.GetAction("ToggleJournal");
                if (toggleAction != null)
                {
                    toggleAction.performed += HandleTogglePerformed;
                }
            }
        }

        private void OnDisable()
        {
            if (toggleAction != null)
            {
                toggleAction.performed -= HandleTogglePerformed;
                toggleAction = null;
            }
        }

        private void Start()
        {
            TrySubscribe();
            if (panelRoot != null)
            {
                panelRoot.SetActive(false);
            }
            if (entryTemplate != null)
            {
                entryTemplate.gameObject.SetActive(false);
            }
        }

        private void OnDestroy()
        {
            if (subscribedJournal != null)
            {
                subscribedJournal.JournalChanged -= HandleJournalChanged;
                subscribedJournal = null;
            }
        }

        private void TrySubscribe()
        {
            if (subscribedJournal != null)
            {
                return;
            }
            subscribedJournal = EvidenceJournal.Instance;
            if (subscribedJournal != null)
            {
                subscribedJournal.JournalChanged += HandleJournalChanged;
            }
        }

        private void HandleJournalChanged()
        {
            dirty = true;
            if (panelRoot != null && panelRoot.activeSelf)
            {
                Rebuild();
            }
        }

        private void HandleTogglePerformed(InputAction.CallbackContext context)
        {
            if (panelRoot == null)
            {
                return;
            }

            bool show = !panelRoot.activeSelf;
            panelRoot.SetActive(show);
            if (show)
            {
                TrySubscribe();
                if (dirty)
                {
                    Rebuild();
                }
            }
        }

        private void Rebuild()
        {
            EvidenceJournal journal = EvidenceJournal.Instance;
            if (journal == null || contentParent == null)
            {
                for (int i = 0; i < spawnedEntries.Count; i++)
                {
                    if (spawnedEntries[i] != null)
                    {
                        spawnedEntries[i].SetActive(false);
                    }
                }
                return;
            }

            int used = 0;
            IReadOnlyList<EvidenceItem> items = journal.Entries;
            for (int i = 0; i < items.Count; i++)
            {
                EvidenceItem item = items[i];
                if (item == null)
                {
                    continue;
                }
                string label = $"[{item.Category} · {item.Provenance}] {item.Title}\n{item.Description}";
                if (used < spawnedEntries.Count && spawnedEntries[used] != null)
                {
                    GameObject entry = spawnedEntries[used];
                    entry.GetComponent<Text>().text = label;
                    entry.SetActive(true);
                }
                else if (used < spawnedEntries.Count)
                {
                    spawnedEntries[used] = CreateEntry(label);
                }
                else
                {
                    spawnedEntries.Add(CreateEntry(label));
                }
                used++;
            }

            for (int i = used; i < spawnedEntries.Count; i++)
            {
                if (spawnedEntries[i] != null)
                {
                    spawnedEntries[i].SetActive(false);
                }
            }

            dirty = false;
        }

        private GameObject CreateEntry(string label)
        {
            Text text;
            if (entryTemplate != null)
            {
                text = Instantiate(entryTemplate, contentParent);
                text.gameObject.SetActive(true);
            }
            else
            {
                var entry = new GameObject("JournalEntry", typeof(RectTransform));
                entry.transform.SetParent(contentParent, false);
                text = entry.AddComponent<Text>();
                text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                text.fontSize = runtimeFontSize;
                text.color = Color.white;
                var rect = (RectTransform)entry.transform;
                rect.sizeDelta = new Vector2(360f, 64f);
            }

            text.text = label;
            return text.gameObject;
        }
    }
}
