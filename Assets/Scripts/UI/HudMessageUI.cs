using UnityEngine;
using UnityEngine.UI;

namespace PurpleRain.UI
{
    /// <summary>
    /// One-line HUD message sink with auto-hide. The single-argument
    /// <see cref="Show(string)"/> overload is UnityEvent&lt;string&gt;-bindable, so
    /// ExaminePoint.onExamined, TriggerVolume messages (via StoryBeatListener) and
    /// EvidencePickup.onCollectedMessage can all print here with no extra code.
    /// </summary>
    public sealed class HudMessageUI : MonoBehaviour
    {
        [SerializeField] private GameObject messageRoot;
        [SerializeField] private Text messageText;
        [SerializeField] private float defaultDuration = 4f;

        private float hideAt = -1f;

        private void Start()
        {
            if (messageRoot != null)
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

        public void Hide()
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
                Hide();
            }
        }
    }
}
