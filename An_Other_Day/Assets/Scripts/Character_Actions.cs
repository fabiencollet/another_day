using UnityEngine;

public class Character_Actions : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    
    
    
    // Update is called once per frame
    void Update()
    {
        Simple_Movement();
    }

    void Simple_Movement()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _moveSpeed * transform.forward;
        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _moveSpeed * -transform.forward;
        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _moveSpeed * -transform.right;
        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * _moveSpeed * transform.right;

    }

}
