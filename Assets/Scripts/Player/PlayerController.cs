using UnityEngine;
using UnityEngine.InputSystem;
using PurpleRain.Core;

namespace PurpleRain.Player
{
    /// <summary>
    /// First-person player controller: walk, sprint, crouch (smoothed), jump,
    /// gravity, grounded handling and mouse look.
    ///
    /// Camera contract (Cinemachine-ready): this script yaws the body transform and
    /// pitches <see cref="cameraPivot"/> only. Either parent the Main Camera under
    /// the pivot directly, or point a Cinemachine 3.x CinemachineCamera at the pivot
    /// (Follow = CameraPivot, Hard Lock To Target + Rotate With Follow Target).
    /// No Cinemachine API is used at runtime.
    ///
    /// Input comes from an InputActionsProvider resolving the "Player" map of
    /// Assets/Input/PurpleRain.inputactions (no generated wrapper class).
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public sealed class PlayerController : MonoBehaviour
    {
        [Header("Input")]
        [SerializeField] private InputActionsProvider input;

        [Header("Camera")]
        [SerializeField] private Transform cameraPivot;
        [SerializeField] private float lookSensitivity = 0.12f;
        [SerializeField] private float pitchLimit = 85f;
        [SerializeField] private bool lockCursorOnStart = true;

        [Header("Movement")]
        [SerializeField] private float walkSpeed = 3.4f;
        [SerializeField] private float sprintSpeed = 5.6f;
        [SerializeField] private float crouchSpeed = 1.8f;
        [SerializeField] private float jumpHeight = 1.0f;
        [SerializeField] private float gravity = -19.62f;

        [Header("Crouch")]
        [SerializeField] private float standingHeight = 1.8f;
        [SerializeField] private float crouchedHeight = 1.2f;
        [SerializeField] private float crouchTransitionSpeed = 4.5f;
        [SerializeField] private float eyeOffsetFromTop = 0.15f;

        private CharacterController controller;
        private InputAction moveAction;
        private InputAction lookAction;
        private InputAction jumpAction;
        private InputAction sprintAction;
        private InputAction crouchAction;

        private float pitch;
        private float verticalVelocity;
        private float currentHeight;
        private bool wantsCrouch;

        public Transform CameraPivot => cameraPivot;
        public bool IsCrouching => wantsCrouch || currentHeight < standingHeight - 0.01f;
        public bool IsGrounded => controller != null && controller.isGrounded;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            currentHeight = standingHeight;
            ApplyHeight(currentHeight);
        }

        private void OnEnable()
        {
            if (input == null)
            {
                Debug.LogError("PlayerController: no InputActionsProvider assigned.", this);
                return;
            }

            moveAction = input.GetAction("Move");
            lookAction = input.GetAction("Look");
            jumpAction = input.GetAction("Jump");
            sprintAction = input.GetAction("Sprint");
            crouchAction = input.GetAction("Crouch");
        }

        private void Start()
        {
            if (lockCursorOnStart)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        private void Update()
        {
            HandleLook();
            HandleCrouch();
            HandleMove();
        }

        private void HandleLook()
        {
            if (lookAction == null)
            {
                return;
            }

            Vector2 look = lookAction.ReadValue<Vector2>() * lookSensitivity;
            transform.Rotate(0f, look.x, 0f);

            pitch = Mathf.Clamp(pitch - look.y, -pitchLimit, pitchLimit);
            if (cameraPivot != null)
            {
                cameraPivot.localRotation = Quaternion.Euler(pitch, 0f, 0f);
            }
        }

        private void HandleCrouch()
        {
            wantsCrouch = crouchAction != null && crouchAction.IsPressed();

            float targetHeight = wantsCrouch ? crouchedHeight : standingHeight;
            if (targetHeight > currentHeight && !HasHeadroom(targetHeight))
            {
                targetHeight = currentHeight; // blocked by a ceiling — stay low
            }

            if (!Mathf.Approximately(targetHeight, currentHeight))
            {
                currentHeight = Mathf.MoveTowards(currentHeight, targetHeight, crouchTransitionSpeed * Time.deltaTime);
                ApplyHeight(currentHeight);
            }
        }

        private void HandleMove()
        {
            bool grounded = controller.isGrounded;

            Vector2 moveInput = moveAction != null ? moveAction.ReadValue<Vector2>() : Vector2.zero;
            Vector3 wishDirection = transform.right * moveInput.x + transform.forward * moveInput.y;
            wishDirection = Vector3.ClampMagnitude(wishDirection, 1f);

            bool sprinting = !IsCrouching
                             && sprintAction != null && sprintAction.IsPressed()
                             && moveInput.y > 0.1f;
            float speed = IsCrouching ? crouchSpeed : (sprinting ? sprintSpeed : walkSpeed);

            if (grounded && verticalVelocity < 0f)
            {
                verticalVelocity = -2f; // keep the controller pressed to the ground
            }

            if (grounded && !IsCrouching && jumpAction != null && jumpAction.WasPressedThisFrame())
            {
                verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            verticalVelocity += gravity * Time.deltaTime;

            Vector3 velocity = wishDirection * speed + Vector3.up * verticalVelocity;
            controller.Move(velocity * Time.deltaTime);
        }

        private void ApplyHeight(float height)
        {
            controller.height = height;
            controller.center = new Vector3(0f, height * 0.5f, 0f);
            if (cameraPivot != null)
            {
                cameraPivot.localPosition = new Vector3(0f, height - eyeOffsetFromTop, 0f);
            }
        }

        private bool HasHeadroom(float targetHeight)
        {
            float radius = controller.radius * 0.95f;
            float castDistance = (targetHeight - currentHeight) + 0.05f;
            Vector3 castStart = transform.position + Vector3.up * (currentHeight - radius);
            return !Physics.SphereCast(
                new Ray(castStart, Vector3.up),
                radius,
                castDistance,
                Physics.AllLayers,
                QueryTriggerInteraction.Ignore);
        }
    }
}
