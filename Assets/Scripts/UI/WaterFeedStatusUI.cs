using UnityEngine;
using UnityEngine.UI;

namespace PurpleRain.UI
{
    /// <summary>
    /// Persistent one-line readout for the valve network's partial progress —
    /// the slice's "wrong routing shows immediately as flow/pressure feedback"
    /// behavior (PUZZLES.md P-A2-S03-1 fail states). Bind
    /// <see cref="ShowProgress(int, int)"/> to WaterFeedPuzzle.onProgressChanged
    /// (dynamic int, int) in the inspector; the puzzle fires it on Start and on
    /// every valve change, so the readout is live from the first frame.
    /// </summary>
    public sealed class WaterFeedStatusUI : MonoBehaviour
    {
        [SerializeField] private Text statusText;

        public void ShowProgress(int satisfied, int total)
        {
            if (statusText != null)
            {
                statusText.text = $"Junction balance: {satisfied}/{total} legs reading right";
            }
        }
    }
}
