using System.Net.Sockets;
using UnityEngine;

public class ToolsMovement : MonoBehaviour
{
    public Rigidbody rbTools;
    
    //reference interaction with tools
    public bool grabbed = false;
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
        if (grabbed && Input.GetKey(KeyCode.E))
        {
            //Tools child of player
            transform.parent = body.transform;
            transform.position = body.position + toolsposition;
            rbTools.constraints = RigidbodyConstraints.FreezeAll;
        }

    }


}
