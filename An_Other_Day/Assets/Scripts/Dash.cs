using UnityEngine;

public class Dash : MonoBehaviour
{

    private Rigidbody _rigidbody;

    [SerializeField] private float _dashForce = 10f;
    private bool _shouldDash = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //read input in update
    void Update()
    {
        if (_shouldDash == false)
            _shouldDash = Input.GetKey(KeyCode.LeftShift);
    }
    //act on FixedUpdate
    //can miss an input if not update each frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (Input.GetKey(KeyCode.LeftShift) && _shouldDash)
        {
            _rigidbody.AddForce(_dashForce * newPosition);
            _shouldDash = false;
        }
    }

}
