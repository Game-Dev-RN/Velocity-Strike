using UnityEngine;


namespace Player
{
    public class InputManagerBehaviour : MonoBehaviour
    {
        private InputSystem_Actions playerInput;
        private InputSystem_Actions.PlayerActions player;

        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerInput = new InputSystem_Actions();
            player = playerInput.Player;
            playerMovement = GetComponent<PlayerMovement>();
        }

        void Start()
        {
        
        }


        void FixedUpdate()
        {
            playerMovement.Move(player.Move.ReadValue<Vector2>());
            playerMovement.Jump(player.Jump.ReadValue<float>());
            
            
        }


        private void OnEnable()
        {
            playerInput.Enable();
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }
    }
}
