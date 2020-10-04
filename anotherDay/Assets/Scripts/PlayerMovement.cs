using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the rigidbody component "rb"
    public Rigidbody rb;

    public Transform Player;
    
    //reference to the direction
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    public float jumpForce = 2000f;
    public bool grounded = true;
 

    // Update is called once per frame
    void FixedUpdate()
    {
        //Menu
        Move();
        

    }

    private void Move()
    {

        //Add a forward force in 5 directions
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("space") && grounded == true)
        {
            rb.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
            grounded = false;
        }
        else if (Player.position.y == 1)
        {
            grounded = true;
        }
        
    }
}
