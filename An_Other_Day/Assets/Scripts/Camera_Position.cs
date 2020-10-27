using UnityEngine;

public class Camera_Position : MonoBehaviour
{
    public Transform Player1;
    public Vector3 _offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 _moveCamera = new Vector3(Player1.position.x, 0, Player1.position.z);
        transform.position = _moveCamera + _offset;
        
    }
}
