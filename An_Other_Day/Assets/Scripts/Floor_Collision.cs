using UnityEngine;

public class Floor_Collision : MonoBehaviour
{
    public Jump Jump;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Floor")
        {
            Jump.grounded = true;
            Debug.Log("I'm touching the floor");
        }
    }
}
