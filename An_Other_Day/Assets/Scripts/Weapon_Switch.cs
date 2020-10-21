using UnityEngine;

public class Weapon_Switch : MonoBehaviour
{
    public int Selected_Weapon = 0;

    // Start is called before the first frame update
    void Start()
    {        
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int Previous_Selected_Weapon = Selected_Weapon;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (Selected_Weapon >= transform.childCount - 1)
                Selected_Weapon = 0;
            else
                Selected_Weapon++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (Selected_Weapon <= 0)
                Selected_Weapon = transform.childCount - 1;
            else
                Selected_Weapon--;
        }

        if (Previous_Selected_Weapon != Selected_Weapon)
            SelectWeapon();
    }
    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == Selected_Weapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
