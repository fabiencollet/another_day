using UnityEngine;

public class Dash : MonoBehaviour
{
    public ParticleSystem dashParticle;

    public bool isDashing;
    [SerializeField] private float _dashForce = 30f;
    [SerializeField] private float _dashStam = 10f;
    [SerializeField] private float _jumpStam = 14f;
    private int dashAttempts;
    private float dashStartTime;

    [SerializeField] private Vector3 _dashScale = new Vector3(1,1,1);

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
        Stats_Player stats_Player = GetComponent<Stats_Player>();
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
        bool isTryingToDash = Input.GetKeyDown(KeyCode.Space);
        if (stats_Player.IHaveStam)
        {
            if (isTryingToDash && !isDashing)
            {
                if (dashAttempts <= 50)
                {
                    OnStartDash();
                }
            }

            if (isDashing)
            {
                if (Time.time - dashStartTime <= 0.4f)
                {
                    if (character_Actions.movementVector.Equals(Vector3.zero))
                    {
                        //Player is not giving any input
                        transform.position += transform.up * _dashForce / 2 * Time.deltaTime;
                        transform.localScale = _dashScale;
                        stats_Player.useStamina(_jumpStam);
                        stats_Player.IDoSomething = true;
                    }
                    else
                    {
                        transform.position += character_Actions.movementVector.normalized * _dashForce * Time.deltaTime;
                        transform.localScale = _dashScale;
                        stats_Player.useStamina(_dashStam);
                        stats_Player.IDoSomething = true;
                    }
                }
                else
                {
                    OnEndDash();
                    stats_Player.IDoSomething = false;
                    stats_Player.recoverStamina();
                }

            }
        }
        else
            transform.position = newPosition;
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
        transform.localScale = new Vector3(1,1,1);
    }
}
