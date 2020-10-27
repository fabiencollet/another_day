using UnityEngine;

public class Character_rotation_grphx : MonoBehaviour
{
    [SerializeField] public float _rotationSpeed = 50f;


    // Update is called once per frame
    void Update()
    {
        {
            float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");

            Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.LookAt(newPosition + transform.position);

        }
    }
}

