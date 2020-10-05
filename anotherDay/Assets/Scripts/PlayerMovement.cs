using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the rigidbody component "rb"
    public Rigidbody rb;

    public Transform Player;
    public PlayerCollision playerCollision;
    
    //reference to the direction
    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;
    public float jumpForce = 2000f;
    public int accelerationValue = 3000;
    //public bool grounded = true;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        //Menu
        Move();
        
    }

    private void Move()
    {

        //Add a forward force in 5 directions
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 3000 * Time.deltaTime), ForceMode.Acceleration + 3000);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        //test saut sur place
        if (Input.GetKey(KeyCode.Space) && playerCollision.grounded)
        {
            rb.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
            Debug.Log("CA NE PLANTE PAAAAAS");
        }
        /*else if (Player.position.y == 1)
        {
            playerCollision.setGround(true);
        }*/

        if (Input.GetKey(KeyCode.LeftShift)  && Input.GetKey(KeyCode.W))
    {
        rb.AddForce(new Vector3(0, 0, Time.deltaTime), ForceMode.Acceleration + accelerationValue);
    }
    if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space) && playerCollision.grounded)
    {
            rb.AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
            Debug.Log("CA NE PLANTE PAAAAAS");
    }

    }
}
