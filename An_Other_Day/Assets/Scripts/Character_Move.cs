using UnityEngine;

public class Character_Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _gravity = 2f;
    [SerializeField] private float _jumpSpeed = 0.5f;
    //[SerializeField] private float _rotationSpeed = 5f;

    public bool collisionFloor;
    public bool grabbed = false;
    public bool equipped = false;
    //reference to CharacterController
    //motor that drives player
    CharacterController _characterController;
    Vector3 _moveDirection = Vector3.zero;
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

  
    void FixedUpdate()
    {
        SimpleMovement();
    }
    private bool PlayerJumped => collisionFloor && Input.GetButton("Jump");
    private void SimpleMovement()
    {
        // Movement

        //Input in certain direction
        //Value between -1 and 1 = Horizontal Input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Vector3 to point to a direction
        //mooving with x and z axis
        //normalized for diagonal 
        Vector3 inputDirection = new Vector3(horizontal, 0, vertical);

        //use and transform the input Direction
        Vector3 transformDirection = transform.TransformDirection(inputDirection);

        Vector3 flatMovement = _moveSpeed * Time.deltaTime * transformDirection;
        //input on x and z
        //y axis manage with _moveDirection
        _moveDirection = new Vector3(flatMovement.x, _moveDirection.y, flatMovement.z);

        //refer to bool PlayerJumped
        if (PlayerJumped)
        {
            _moveDirection.y = _jumpSpeed;
            collisionFloor = false;
        }


        else if (_characterController.isGrounded)
            _moveDirection.y = 0f;

        else
            _moveDirection.y -= _gravity * Time.deltaTime;

        //mooving player
        _characterController.Move(_moveDirection);
    }

}
