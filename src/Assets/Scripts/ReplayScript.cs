using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    public GameObject HealthBar;
    public GameObject YourScore;

    public void Replay()
    {
        HealthBar.SetActive(false);
        YourScore.SetActive(false);
        Level2.SetActive(false);
        Level1.SetActive(true);
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

    }
}
