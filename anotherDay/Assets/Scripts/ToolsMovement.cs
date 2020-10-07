using System.Net.Sockets;
using UnityEngine;

public class ToolsMovement : MonoBehaviour
{
    public Rigidbody rbTools;
    
    //reference interaction with tools
    public bool grabbed = false;
    public bool equipped = false;
    //grabbed avec deux B
    public Transform body;
    public Vector3 toolsposition;

    private void Start()
    {
        rbTools = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        //grab tools on the floor
        if (grabbed && Input.GetKey(KeyCode.E))
        {
            //Tools child of player
            transform.parent = body.transform;
            transform.position = body.position + toolsposition;
            rbTools.constraints = RigidbodyConstraints.FreezeAll;
            equipped = true;

        }
        //throw tools equipped
        if (Input.GetKey(KeyCode.E) && equipped)
        {
            rbTools.AddForce(new Vector3(0, 1, 1),ForceMode.Impulse);
            grabbed = false;
            equipped = false;
        }

    }


}
