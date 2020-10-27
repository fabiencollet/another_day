using UnityEngine;

public class Dash : MonoBehaviour
{
    public ParticleSystem dashParticle;

    public bool isDashing;
    [SerializeField] private float _dashForce = 30f;
    private int dashAttempts;
    private float dashStartTime;

    Character_Actions character_Actions;

    void Start()
    {
        character_Actions = GetComponent<Character_Actions>();
   
    }


    void Update()
    {
        HandleDash();
    }

    void HandleDash()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
        bool isTryingToDash = Input.GetKeyDown(KeyCode.Space);

        if (isTryingToDash && !isDashing)
        {
            if(dashAttempts <= 50)
            {
                OnStartDash();
            }
        }

        if(isDashing)
        {
            if (Time.time - dashStartTime <= 0.4f)
            {
                if(character_Actions.movementVector.Equals(Vector3.zero))
                {
                    //Player is not giving any input
                    transform.position += transform.up * _dashForce * Time.deltaTime;
                }
                else
                {
                    transform.position += character_Actions.movementVector.normalized * _dashForce * Time.deltaTime;
                }                
            }
            else
                OnEndDash();
        }
    }

    void OnStartDash()
    {
        isDashing = true;
        dashStartTime = Time.time;
        dashAttempts = 1;
        dashParticle.Play();
    }
    void OnEndDash()
    {
        isDashing = false;
        dashStartTime = 0;
    }
}
