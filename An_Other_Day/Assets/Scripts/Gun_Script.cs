using UnityEngine;

public class Gun_Script : MonoBehaviour
{
    public ParticleSystem Gun_Particle;

    [SerializeField] private float _damage = 10f;
    [SerializeField] private float _range = 100f;
    
    public Vector3 _posWeapon;

    public bool equipped = false;
    public bool grabbed = false;

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        Equip_Throw();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        { 
            Shoot();
            Gun_Particle.Play();
            Debug.Log("Je tire");
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, _range))
        {
            Debug.Log(hit.transform.name);
        }
    }
    void Equip_Throw()
    {
        //grab tools on the floor
        if (grabbed && Input.GetKey(KeyCode.E))
        {

        }
        //throw tools equipped
        if (equipped && Input.GetKey(KeyCode.G))
        {

        }
    }
}
