using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody _rigidbody;
    public bool grounded;
    [SerializeField] private float _jumpForce = 30f;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //read input in update
    private void Update()
    {
        if (grounded == false)
            grounded = Input.GetKeyDown(KeyCode.Space);
    }
    //act on FixedUpdate
    //can miss an input if not update each frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            _rigidbody.AddForce(_jumpForce * Vector3.up);
            grounded = false;
        }
    }
}
