using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeepAtRandom : MonoBehaviour
{
    //public GameObject Cannibal;
    public GameObject Axe;
    public GameObject AxeButton;
    public GameObject RevolverButton;
    public GameObject WoodenBowButton;
    public GameObject ShotgunButton;
    public GameObject HealthBar;
    public GameObject BatController;
    public GameObject Score;
    public GameObject Crosshair;
    public GameObject ShootButton;
    public GameObject[] Bat;
    public GameObject Spawner;
    public GameObject PlacementIndicator;
    public GameObject StartButton;
    public GameObject Loader;
    private Text Caption;

 
   // public GameObject Cam;
    //private Vector3 Pos;
    bool done = false;
    //c private float y;
    //public GameObject Origin;
    //public PlacementIndicator Plane;
    //public GameObject[] life;
    //int i = 0;
    int j = 0;
    //int k = 0;
    // Start is called before the first frame update
   

    void Start()
    {
        Loader.SetActive(true);
        Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
        if (ScoreScript.scoreValue < 150)
        {
           // Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
            //Caption.text="Starting...";
            InvokeRepeating("SpawnBats", 5, 0);
            InvokeRepeating("voke", 8, 0);
        }
    }
    void Update()
    {
        //c if (GameObject.FindWithTag("Plane") && j==0)
        //c {

        //if (ScoreScript.scoreValue < 150)
        
           /* if (done && j == 1)
            {
                //GameObject.FindWithTag("StartButton").SetActive(true);
                //GameObject.FindWithTag("InstructionBackground").SetActive(true);
                StartButton.SetActive(true);

                //(correct)Caption.text = "Tap on the screen";
                j++;
            }
        
        /*if (j != 0)
        {
            if (ScoreScript.scoreValue >= 0 && k == 0)
            {
                StartButton.SetActive(true);

                //Caption.text = "Tap on the screen";
                k++;

            }
        }*/
       //c }
    }
    public void Play()
    {
        
        
        //Text Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
        //Caption.text = "You don't have any weapon to fight with enemies. Go Find Weapons to kill enemies";
        /*y=GameObject.FindWithTag("Plane").transform.position.y + GameObject.FindWithTag("MainCamera").transform.position.y;
        for (int i = 0; i < 2; i++)
        {
            // float x = Random.Range(20f, 40f);
            // Pos = placementIndicator.transform.position + new Vector3(Random.Range(20,40),0,Random.Range(20,40));
            //Pos.y = y;
            Instantiate(Cannibal, new Vector3(Random.Range(10, 20), y, Random.Range(10, 20)), Quaternion.identity);
            // Instantiate(Cannibal, Pos, Quaternion.identity);
        }

        for (int i = 0; i < 2; i++)
        {
            // Pos = placementIndicator.transform.position + new Vector3(Random.Range(-40, -20), 0, Random.Range(-40, -20));
            // Instantiate(Cannibal, Pos, Quaternion.identity);
            Instantiate(Cannibal, new Vector3(Random.Range(-10, -20), y, Random.Range(-10, -20)), Quaternion.identity);
        }*/
        
        //c if (Cannibal)
        //{
            //Text Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
            
            //GameObject.FindWithTag("StartButton").SetActive(false);
         Caption.text = "Go find enemies and kill them";
        
            StartButton.SetActive(false);
            HealthBar.SetActive(true);
           
            Score.SetActive(true);
            Crosshair.SetActive(true);
            ShootButton.SetActive(true);
            Axe.SetActive(true);
            AxeButton.SetActive(true);
            RevolverButton.SetActive(true);
            WoodenBowButton.SetActive(true);
            ShotgunButton.SetActive(true);
            PlacementIndicator.SetActive(true);
            Spawner.SetActive(true);
            BatController.SetActive(true);
            
            //Bat.SetActive(true);
            //Instantiate(Bat, new Vector3(0f, 0f, 0f), Quaternion.identity);
            //j++;
            //Destroy(GameObject.FindWithTag("Plane"));
            //Origin.GetComponent<ARPlaneManager>().SetActive(false);
            
            /*for (int i = 0; i < 3; i++)
            {
                life[i].SetActive(true);
            }*/
       // }
        //i = 1;
        
        
    }

    /*void Spawn()
    {
        if (i == 1)
        {
            for (int i = 0; i < 2; i++)
            {
                // float x = Random.Range(20f, 40f);
                // Pos = placementIndicator.transform.position + new Vector3(Random.Range(20,40),0,Random.Range(20,40));
                //Pos.y = y;
                Instantiate(Cannibal, new Vector3(Random.Range(10, 20), y, Random.Range(10, 20)), Quaternion.identity);
                // Instantiate(Cannibal, Pos, Quaternion.identity);
            }

            for (int i = 0; i < 2; i++)
            {
                // Pos = placementIndicator.transform.position + new Vector3(Random.Range(-40, -20), 0, Random.Range(-40, -20));
                // Instantiate(Cannibal, Pos, Quaternion.identity);
                Instantiate(Cannibal, new Vector3(Random.Range(-10, -20), y, Random.Range(-10, -20)), Quaternion.identity);
            }
        }
    }*/

    void SpawnBats()
    {
        for (int i = 0; i < 25; i++)
        {
            Text Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
            Caption.text = " ";
            Instantiate(Bat[i], new Vector3(Random.Range(-40f, 40f), Random.Range(-0.3f, 0.3f), Random.Range(-40f, 40f)), Quaternion.identity);
            done = true;
            j = 1;
        }
        
    }

    void voke()
    {
        StartButton.SetActive(true);
    }
   
}
