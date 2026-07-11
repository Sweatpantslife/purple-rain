using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PurpleRain.UI
{
    /// <summary>
    /// One-line HUD message sink with auto-hide. The single-argument
    /// <see cref="Show(string)"/> overload is UnityEvent&lt;string&gt;-bindable, so
    /// ExaminePoint.onExamined, TriggerVolume messages (via StoryBeatListener) and
    /// EvidencePickup.onCollectedMessage can all print here with no extra code.
    /// Messages that arrive while one is on screen queue up and play in order
    /// (e.g. a trigger bark followed same-frame by its story-beat line), so no
    /// caller ever silently overwrites another.
    /// </summary>
    public sealed class HudMessageUI : MonoBehaviour
    {
        [SerializeField] private GameObject messageRoot;
        [SerializeField] private Text messageText;
        [SerializeField] private float defaultDuration = 4f;

        private readonly Queue<(string message, float duration)> pending = new Queue<(string, float)>();
        private float hideAt = -1f;

        private void Start()
        {
            if (messageRoot != null && hideAt < 0f)
            {
                messageRoot.SetActive(false);
            }
        }

        public void Show(string message)
        {
            Show(message, defaultDuration);
        }

        public void Show(string message, float duration)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            if (hideAt > 0f)
            {
                pending.Enqueue((message, duration));
                return;
            }
            Display(message, duration);
        }

        public void Hide()
        {
            pending.Clear();
            HideCurrent();
        }

        private void Display(string message, float duration)
        {
            if (messageText != null)
            {
                messageText.text = message;
            }
            if (messageRoot != null)
            {
                messageRoot.SetActive(true);
            }
            hideAt = Time.time + Mathf.Max(0.5f, duration);
        }

        private void HideCurrent()
        {
            if (messageRoot != null)
            {
                messageRoot.SetActive(false);
            }
            hideAt = -1f;
        }

        private void Update()
        {
            if (hideAt > 0f && Time.time >= hideAt)
            {
                if (pending.Count > 0)
                {
                    (string message, float duration) = pending.Dequeue();
                    Display(message, duration);
                }
                else
                {
                    HideCurrent();
                }
            }
        }
    }
}
