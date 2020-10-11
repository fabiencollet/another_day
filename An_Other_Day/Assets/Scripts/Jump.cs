using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody _rigidbody;

    [SerializeField] private float _jumpForce = 300f;
    private bool _shouldJump = true;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //read input in update
    void Update()
    {
        if (_shouldJump == false)
            _shouldJump = Input.GetButton("Jump");
    }
    //act on FixedUpdate
    //can miss an input if not update each frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump")&&_shouldJump)
        {
            _rigidbody.AddForce(_jumpForce * Vector3.up);
            _shouldJump = false;
        }
    }
}
