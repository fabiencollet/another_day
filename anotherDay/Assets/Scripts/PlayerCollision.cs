using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Floor")
        {
            movement.grounded = true;
            Debug.Log("Player is Grounded, grounded == true");
        }  
    }
        
}
 