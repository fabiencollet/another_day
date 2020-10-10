using UnityEngine;

public class Camera_Position : MonoBehaviour
{
    public Transform Player1;
    public Vector3 _offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Player1.position + _offset;
    }
}
