using UnityEngine;
using UnityEngine.UI;
using PurpleRain.Interaction;

namespace PurpleRain.UI
{
    /// <summary>
    /// Minimal hover-prompt readout: subscribes to the <see cref="Interactor"/>'s
    /// PromptChanged event and shows/hides a uGUI Text accordingly.
    /// </summary>
    public sealed class InteractionPromptUI : MonoBehaviour
    {
        [SerializeField] private Interactor interactor;
        [SerializeField] private GameObject promptRoot;
        [SerializeField] private Text promptText;

        private void OnEnable()
        {
            if (interactor != null)
            {
                interactor.PromptChanged += HandlePromptChanged;
            }
        }

        private void OnDisable()
        {
            if (interactor != null)
            {
                interactor.PromptChanged -= HandlePromptChanged;
            }
        }

        private void Start()
        {
            if (promptRoot != null)
            {
                promptRoot.SetActive(false);
            }
        }

        private void HandlePromptChanged(string prompt)
        {
            bool hasPrompt = !string.IsNullOrEmpty(prompt);
            if (promptRoot != null)
            {
                promptRoot.SetActive(hasPrompt);
            }
            if (hasPrompt && promptText != null)
            {
                promptText.text = prompt;
            }
        }
    }
}
