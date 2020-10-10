using System;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public Transform PosJoueur;
    public float SpeedEnemy = 2f;
    public Rigidbody bodyZombie;


    // Update is called once per frame
    void FixedUpdate()
    {
        //Direction Point A à B
        var direction = PosJoueur.position - transform.position;
        var angle = Vector3.Angle(direction, this.transform.forward);


        if (angle < 180 && direction.magnitude < 12)
        {
            var rotation = Quaternion.Slerp(
                this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime);
            rotation.x = 0;
            rotation.z = 0;
            transform.rotation = rotation;

            if (direction.magnitude > 1)
                transform.Translate(0, 0, Time.deltaTime * SpeedEnemy);
            
        }
    }
}
