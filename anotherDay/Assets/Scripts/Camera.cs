using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player1;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player1.position + offset;
    }
}
