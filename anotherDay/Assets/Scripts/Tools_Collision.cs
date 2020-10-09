using UnityEngine;

public class Tools_Collision : MonoBehaviour
{
    public Tools_Movement toolsMovement;

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
