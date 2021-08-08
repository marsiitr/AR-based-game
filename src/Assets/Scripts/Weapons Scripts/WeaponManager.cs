using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponManager : MonoBehaviour
{
    [SerializeField]
    private WeaponsHandler[] weapons;
    //public GameObject EquipButton;
    //public Text Caption;
   // int i = 0;

   /// int distance = 5;

    private int current_Weapon_Index;
    // Start is called before the first frame update
    /*void Start()
    {
        //current_Weapon_Index = 0;
       // weapons[current_Weapon_Index].gameObject.SetActive(true);
    }*/

    // Update is called once per frame
    //void Update()
   // {
       // weapons[current_Weapon_Index].transform.position = weapons[current_Weapon_Index].transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
    //}

    public void TurnOnSelecedWeapon(int weaponIndex)
    {
        //if (current_Weapon_Index == weaponIndex)
        //return;
        //if (i == 0)
        /*{
            weapons[weaponIndex].gameObject.SetActive(true);
            current_Weapon_Index = weaponIndex;
            i++;
        }*/
       // else
        //{
            weapons[current_Weapon_Index].gameObject.SetActive(false);
            weapons[weaponIndex].gameObject.SetActive(true);
            current_Weapon_Index = weaponIndex;
           // EquipButton.SetActive(false);
            //Caption.text = "        Find enemies and kill them!!";
        //}
    }

    public WeaponsHandler GetCurrentSelectedWeapon()
    {
        return weapons[current_Weapon_Index];
    }

  
}
