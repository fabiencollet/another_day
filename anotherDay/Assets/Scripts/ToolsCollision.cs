using UnityEngine;

public class ToolsCollision : MonoBehaviour
{
    public ToolsMovement toolsMovement;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Tools")
        {
            toolsMovement.grabbed = true;
            Debug.Log("I'm holding something MF");
        }
    }
}
