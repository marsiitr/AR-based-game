using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public static int CurrentHealth = 100;
    public GameObject[] life;
    int i;
    public GameObject frame;
    bool IsAttacking = false;
    public GameObject GameOverImage;
    public GameObject ButtonController;
    public GameObject ReplayButton;
    public GameObject ExitButton;
    public GameObject Score;
    public GameObject[] Objects;

    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            life[i].SetActive(true);
        }
        SetHealth(100);
        CurrentHealth = 100;
        i = 2;
        InvokeRepeating("UnFrame",0, 2f);
    }

    public void Update()
    {
        Reduce();
        
        if (IsAttacking)
        {
            frame.SetActive(true);
        }
        else
        {
            frame.SetActive(false);
        }
        SetHealth(CurrentHealth);
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        SetHealth(CurrentHealth);
    }
    void Reduce()
    {
        if (CurrentHealth==0 || CurrentHealth < 0)
        {
            if (i >= 0)
            {
                life[i].SetActive(false);
            }
            i=i-1;
            if (i > 0 || i == 0)
            {
                //healthBar.slider.value = 100;
                CurrentHealth = 100;
                SetHealth(CurrentHealth);
            }
            if (i < 0)
            {
                Destroy(GameObject.FindWithTag("Enemy"));
                Destroy(GameObject.FindWithTag("Bat"));
                ButtonController.SetActive(false);
                for (int j = 0; j < 17; j++)
                {
                    Objects[j].SetActive(false);
                }
                GameOverImage.SetActive(true);
                Score.SetActive(true);
                ReplayButton.SetActive(true);
                ExitButton.SetActive(true);
                Text YourScore = GameObject.FindWithTag("YourScore").GetComponent<Text>();
                YourScore.text = "Your Score: " + ScoreScript.scoreValue;

            }
        }
    }
    public void Frame()
    {
        IsAttacking = true;       
    }

    public void UnFrame()
    {
        IsAttacking = false; 
    }
}
