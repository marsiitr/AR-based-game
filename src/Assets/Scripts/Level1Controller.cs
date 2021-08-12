using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Controller : MonoBehaviour
{
    public GameObject Level1Image;
    public GameObject ButtonController;
    public GameObject ObjectSpawner;
    public GameObject Level2Controller;
    public GameObject ReplayButton;
    public GameObject ExitButton;
    public GameObject GameOverImage;
    public GameObject BatController;
    public GameObject Player;
    

    void Start()
    {
        ReplayButton.SetActive(false);
        ExitButton.SetActive(false);
        GameOverImage.SetActive(false);
        InvokeRepeating("Level1on", 2, 0);
        InvokeRepeating("Level1off", 5, 0);
    }

    void Update()
    {
        if (ScoreScript.scoreValue >=150)
        {
            ObjectSpawner.SetActive(false);
            //ButtonController.SetActive(false);
            BatController.SetActive(false);
            Destroy(GameObject.FindWithTag("Bat"));
            Destroy(GameObject.FindWithTag("Enemy"));
            Level2Controller.SetActive(true);
            //Player.SetActive(false);

        }
    }
    void Level1on()
    {
        Level1Image.SetActive(true);

    }

    void Level1off()
    {
        Level1Image.SetActive(false);
        ButtonController.SetActive(true);
    }

}
