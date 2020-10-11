using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision_Checker : MonoBehaviour
{
    public Character_Move grounded;
    public Character_Move take;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Floor")
        {
            grounded.collisionFloor = true;
            Debug.Log("Player is Grounded, grounded == true");
        }
    }
}
