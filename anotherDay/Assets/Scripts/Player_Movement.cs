using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //reference to CharacterController
    //motor that drives player
    public CharacterController controller;

    public float speed = 6f;
    // Update is called once per frame
    void Update()
    {
        // Movement

        //Input in certain direction
        //Value between -1 and 1 = Horizontal Input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //Vector3 to point to a direction
        //mooving with x and z axis
        //normalized for diagonal 
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        //check the direction
        //get Input to move
        if(direction.magnitude >= 0.1f)
        {
           // Calculate diagonale
            float targetAngle = Mathf.Atan2(direction.x, direction.y);

            //Time.deltaTime frame rate independant
            controller.Move(direction*speed*Time.deltaTime);
        }
    }
}
