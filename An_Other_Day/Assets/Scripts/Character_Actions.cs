using UnityEngine;

public class Character_Actions : MonoBehaviour
{
    public ParticleSystem runParticle;
    public Rigidbody player;
    public Vector3 movementVector = Vector3.zero;
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _runSpeed = 5f;
    [SerializeField] private Vector3 _runScale = new Vector3(1,1,1);
    public bool isRunning = false;
 

    // Update is called once per frame
    void Update()
    {
        Simple_Movement();
        
    }

    void Simple_Movement()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);

        movementVector = Vector3.ClampMagnitude(transform.right * moveHorizontal + transform.forward * moveVertical, 1.0f);
        
        //Getting input and moving player in space and time 
        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _moveSpeed * transform.forward;
        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _moveSpeed * -transform.forward;
        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _moveSpeed * -transform.right;
        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * _moveSpeed * transform.right;

        //Run
        bool isTryingToRun = Input.GetKey(KeyCode.LeftShift);
        if (isTryingToRun && !isRunning) 
            OnRunStart();
        if (isRunning)
        {
            transform.position += Time.deltaTime * newPosition * _runSpeed;
            transform.localScale = _runScale;
        }
        if (!isTryingToRun)
        {
            OnRunEnd();
            isRunning = false;
            transform.localScale = new Vector3(1, 1, 1);
        }
        
    }

    void OnRunStart()
    {
        isRunning = true;
        runParticle.Play();
    }
    void OnRunEnd()
    {
        runParticle.Stop();
    }
}
