using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float speedX = 6f;
        [SerializeField] float forwardMovement = 5f;

        [SerializeField] FloatingJoystick joystick;

        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }
        void FixedUpdate()
        {
            MovementLogic();
        }

        void MovementLogic()
        {
            float moveHorizontal = joystick.Horizontal;

            Vector3 sidewaysMovement = new Vector3(moveHorizontal * speedX, 0.0f, forwardMovement);

            rb.MovePosition(transform.position + sidewaysMovement * speedX * Time.deltaTime);
        }
    }
}