﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the rigidbody component "rb"
    public Rigidbody rb;
    public Transform Player;

    //reference to the direction
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    public float ratio = 1.5f;
    public float jumpForce = 30f;
    public int accelerationValue = 3000;
    public bool grounded = true;

    // Update is called once per frame

    //Update() is called once per frame while FixedUpdate() can be multiple time
    //Udpate() is for Input, FixedUpdate() is for Physics

    private void Start()
    {
        //assigne the rigid body
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Menu
        Move();
        Jump();
        Accelerate();
    }

    private void Move()
    {
        //simplify lisibility
        float value_sideForce = sidewaysForce * Time.deltaTime;
        float value_forwardForce = forwardForce * Time.deltaTime;

        //Add a forward force in 4 directions
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(value_sideForce, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, value_forwardForce, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-value_sideForce, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -value_forwardForce, ForceMode.VelocityChange);
        }

        //Left up Diagonal
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-value_sideForce / ratio, 0, value_forwardForce / ratio, ForceMode.VelocityChange);
        }
        //right up diagonal
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            rb.AddForce(value_sideForce / ratio, 0, value_forwardForce / ratio, ForceMode.VelocityChange);
        }
        //Right down diagonal
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            rb.AddForce(value_sideForce / ratio, 0, -value_forwardForce / ratio, ForceMode.VelocityChange);
        }
        //Left down diagonal
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-value_sideForce / ratio, 0, -value_forwardForce / ratio, ForceMode.VelocityChange);
        }

    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            grounded = false;
            Debug.Log("Off the ground");
        }

    }

    private void Accelerate()
    {
        //Input adding Acceleration
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(new Vector3(0, 0, accelerationValue * Time.deltaTime));
        }
    }
}
