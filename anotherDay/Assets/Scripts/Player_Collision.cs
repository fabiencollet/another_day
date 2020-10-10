using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public Character movement;
 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Floor")
        {
            movement.grounded = true;
            Debug.Log("Player is Grounded, grounded == true");
        }

    }
        
}
 