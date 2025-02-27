using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        // Fix Player Flickering while moving in play mode todo
        // applay gravity todo
        private CharacterController characterController;
        private Vector3 currentVelocity;
        [SerializeField] private float speed = 20f;
        [SerializeField] private float jumpPower = 20f;
        private float gravity = -9.81f;
        
        void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Move(Vector2 input)
        {
            Vector3 moveDirection = Vector3.zero;
            moveDirection.x = input.x;
            moveDirection.z = input.y;
            characterController.Move(transform.TransformDirection(moveDirection) * (speed * Time.deltaTime));
        }

        public void Jump(float input)
        {
            if (characterController.isGrounded)
                characterController.Move(Vector3.up * (input * jumpPower * Time.deltaTime));
        }
    }
}
