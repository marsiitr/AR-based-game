using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponManager : MonoBehaviour
{
    [SerializeField]
    private WeaponsHandler[] weapons;

 

    private int current_Weapon_Index;
    // Start is called before the first frame update
    void Start()
    {
        current_Weapon_Index = 0;
        weapons[current_Weapon_Index].gameObject.SetActive(true);
    }

    // Update is called once per frame
   // void Update()
    //{
        /*if(Input.GetButton("Axe Button"))
        {
            TurnOnSelecedWeapon(0);
        }
        if (Input.GetButton("Revolver Button"))
        {
            TurnOnSelecedWeapon(1);
        }
        if (Input.GetButton("Shotgun Button"))
        {
            TurnOnSelecedWeapon(2);
        }
        if (Input.GetButton("WoodenBow Button"))
        {
            TurnOnSelecedWeapon(3);
        }*/
        
    //}

    public void TurnOnSelecedWeapon(int weaponIndex)
    {
        if (current_Weapon_Index == weaponIndex)
            return;
        weapons[current_Weapon_Index].gameObject.SetActive(false);
        weapons[weaponIndex].gameObject.SetActive(true);
        current_Weapon_Index = weaponIndex;
    }

    public WeaponsHandler GetCurrentSelectedWeapon()
    {
        return weapons[current_Weapon_Index];
    }

  
}
