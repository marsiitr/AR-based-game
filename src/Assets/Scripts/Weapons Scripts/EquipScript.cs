using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipScript : MonoBehaviour
{
    //private Text Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
    /*public Text Caption;
    public GameObject EquipButton;
    public GameObject ShootButton;
    public GameObject Crosshair;
    public GameObject Camera;
    //public GameObject Axe;
    public GameObject Shotgun;
    public GameObject Revolver;
    public GameObject Bow;
   // public GameObject hand;
    
 
    void Update()
    {
        RaycastHit hit;
       
       // if (Physics.Raycast(GameObject.FindWithTag("MainCamera").transform.position, GameObject.FindWithTag("MainCamera").transform.forward, out hit))
        
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit))
        {
           /*if (hit.transform.name == "Axe_(Clone)" || hit.transform.name == "Axe_")
            {
                EquipButton.SetActive(true);
                //GameObject.FindWithTag("Equip").SetActive(true);
                Background.SetActive(true);
                Caption.text = "You have found Axe!! Click on Equip to get it";
                return;
            }*/
           /* if (hit.transform.name == "Revolver_(Clone)")
            {
                EquipButton.SetActive(true);
                //GameObject.FindWithTag("Equip").SetActive(true);
                Caption.text = "You have found Revolver!! Click on Equip to get it";
                return;
               /* Destroy(hit.transform.gameObject);
                Revolver.SetActive(true);
                //GameObject.FindWithTag("RevolverButton").SetActive(true);
                EquipButton.SetActive(false);*/
           /* }
            else if (hit.transform.name == "ShotGun_(Clone)")
            {
                EquipButton.SetActive(true);
                //GameObject.FindWithTag("Equip").SetActive(true);
                Caption.text = "You have found Shotgun!! Click on Equip to get it";
                return;
            }
            else if (hit.transform.name == "WoodenBow_(Clone)")
            {
                EquipButton.SetActive(true);
                //GameObject.FindWithTag("Equip").SetActive(true);
                Caption.text = "You have found Bow and Arrow!! Click on Equip to get it";
                return;
            }
            else
            {

                EquipButton.SetActive(false);
                Caption.text = " ";
                return;
            }
            
        }

    }

    public void equip()
    {
        RaycastHit hit1;
        //if (Physics.Raycast(GameObject.FindWithTag("MainCamera").transform.position, GameObject.FindWithTag("MainCamera").transform.forward, out hit))
        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit1))
        {
            /*if (hit1.transform.name == "Axe_(Clone)" )
            {

                Off();
                Caption.text = "Find enemies and kill them!!";
                ShootButton.SetActive(true);
                Crosshair.SetActive(true);
                Destroy(hit1.transform.gameObject);
                Axe.SetActive(true);
                return;
                //hand.SetActive(true);
                //GameObject.FindWithTag("AxeButton").SetActive(true);

            }*/

            /*if (hit1.transform.name == "Revolver_(Clone)")
            {

                //GameObject.FindWithTag("Equip").SetActive(false);
                Off();
                ShootButton.SetActive(true);
                Crosshair.SetActive(true);
                Destroy(hit1.transform.gameObject);
                Revolver.SetActive(true);
                return;
                //hand.SetActive(true);
                //GameObject.FindWithTag("RevolverButton").SetActive(true);

            }

            else if (hit1.transform.name == "ShotGun_(Clone)")
            {
                Off();
                ShootButton.SetActive(true);
                Crosshair.SetActive(true);
                Destroy(hit1.transform.gameObject);
                Shotgun.SetActive(true);
                return;
                //hand.SetActive(true);
                //GameObject.FindWithTag("ShotgunButton").SetActive(true);
            }
            else if (hit1.transform.name == "WoodenBow_(Clone)")
            {
                Off();
                ShootButton.SetActive(true);
                Crosshair.SetActive(true);
                Destroy(hit1.transform.gameObject);
                Bow.SetActive(true);
                return;
                //hand.SetActive(true);
                //GameObject.FindWithTag("WoodenBowButton").SetActive(true);
            }

        }

        Off();

        //GameObject.FindWithTag("ShootButton").SetActive(true);
        //GameObject.FindWithTag("Crosshair").SetActive(true);
        
        
        
    }

    void Off()
    {
        EquipButton.SetActive(false);
        Caption.text = "Find enemies and kill them!!";
    }*/

}
