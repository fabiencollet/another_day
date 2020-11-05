using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    private bool IRecover = true;
    public bool IHaveStam = true;
    public bool IDoSomething = false;
    [SerializeField] private float _staminaPts = 20f;
    [SerializeField] private float _lifePts = 100f;
    private float UsingTimeStamina;
    
    public void useStamina (float consumption)
    {
        Exhausted();
        if (IDoSomething)
        {
            StartUsingStam();
            _staminaPts -= consumption;
        }
        else
            EndUsingStam();

        

    }
    public void recoverStamina ()
    {

        if (Time.time - UsingTimeStamina >= 2)
            IRecover = true;
        while (IRecover && _staminaPts != 20)
            _staminaPts += 1;
    }

    void Exhausted()
    {
        if (_staminaPts == 0)  
            IHaveStam = false;
         
        
    }
    void StartUsingStam()
    {
        UsingTimeStamina = Time.time;
        IRecover = false;
    }
    void EndUsingStam()
    {
        UsingTimeStamina = 0;
    }
}
