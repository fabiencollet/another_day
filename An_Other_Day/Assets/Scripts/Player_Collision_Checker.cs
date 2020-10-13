using UnityEngine;

public class Player_Collision_Checker : MonoBehaviour
{
    public Character_Actions grounded;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Floor")
        {
            grounded._grounded = true;
            Debug.Log("Player is Grounded, grounded == true");
        }
    }
}
