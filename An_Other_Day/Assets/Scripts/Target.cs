using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem Blood_On_Hit;
    [SerializeField] public float healt = 50f;
    public ParticleSystem Blood_On_Death;
    public void TakeDamage (float amount)
    {
        healt -= amount;
        Blood_On_Hit.Play();
        if (healt == 0)
        {
            Die();
        }
    }
    void Die()
    {
        Blood_On_Death.Play();
        Destroy(gameObject, 1f);        
    }
}
