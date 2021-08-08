using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    public GameObject Level1Controller;
    public GameObject Level2Image;
   // public GameObject ButtonController;
    //public GameObject[] Weapons;
    public GameObject EnemySpawner;
    public GameObject PlacementIndicator;
    private Text Caption;
    public GameObject BatController;
   // public GameObject Player;
    bool yes = true;

    void Start()
    {
        Destroy();
        Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
        Level2on();
        //InvokeRepeating("Level2on", 0, 0);
        InvokeRepeating("Level2off", 5, 0);
    }
    void Update()
    {
        if (yes)
        {
            Destroy();
        }
    }
    void Level2on()
    {
        Level2Image.SetActive(true);
        //Player.SetActive(false);
       // ButtonController.SetActive(false);
    }

    void Level2off()
    {
        Level2Image.SetActive(false);
        Caption.text = "More Enemies Coming...";
        Level1Controller.SetActive(false);
        //Player.SetActive(true);
        //ButtonController.SetActive(true);
        yes = false;
        EnemySpawner.SetActive(true);
        PlacementIndicator.SetActive(true);
        BatController.SetActive(true);

    }
    void Destroy()
    {
        EnemySpawner.SetActive(false);
        PlacementIndicator.SetActive(false);
        Destroy(GameObject.FindWithTag("Bat"));
        Destroy(GameObject.FindWithTag("Enemy"));

    }
}