using UnityEngine;
using UnityEngine.InputSystem;

namespace PurpleRain.Core
{
    /// <summary>
    /// Single point of access to the game's InputActionAsset.
    /// All gameplay scripts resolve their actions through this component instead of
    /// relying on editor code generation, so the project compiles without any
    /// generated input wrapper class.
    /// Assign Assets/Input/PurpleRain.inputactions to <see cref="actionsAsset"/>.
    /// </summary>
    public sealed class InputActionsProvider : MonoBehaviour
    {
        [SerializeField] private InputActionAsset actionsAsset;
        [SerializeField] private string actionMapName = "Player";

        private InputActionMap map;

        public InputActionAsset Asset => actionsAsset;

        public InputActionMap Map
        {
            get
            {
                if (map == null && actionsAsset != null)
                {
                    map = actionsAsset.FindActionMap(actionMapName, false);
                    if (map == null)
                    {
                        Debug.LogError($"InputActionsProvider: action map '{actionMapName}' not found on '{actionsAsset.name}'.", this);
                    }
                }
                return map;
            }
        }

        /// <summary>Finds an action by name in the configured map. Returns null (with an error log) if missing.</summary>
        public InputAction GetAction(string actionName)
        {
            InputActionMap actionMap = Map;
            if (actionMap == null)
            {
                return null;
            }

            InputAction action = actionMap.FindAction(actionName, false);
            if (action == null)
            {
                Debug.LogError($"InputActionsProvider: action '{actionName}' not found in map '{actionMapName}'.", this);
            }
            return action;
        }

        private void OnEnable()
        {
            InputActionMap actionMap = Map;
            if (actionMap != null)
            {
                actionMap.Enable();
            }
        }

        private void OnDisable()
        {
            if (map != null)
            {
                map.Disable();
            }
        }
    }
}
