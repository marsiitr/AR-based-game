using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Slider slider;
    public GameObject Loader;
    public GameObject Frame;
    public float CurrentLoad=0;
    public Text number;
    void Start()
    {
        Frame.SetActive(true);
        InvokeRepeating("increase", 0f, 0.05f);
        
    }

    void Update()
    {
        if (slider.value == 100)
        {
            Frame.SetActive(false);
            Loader.SetActive(false);
        }
    }
    void increase()
    {
        if (slider.value < 100)
        {
            slider.value = slider.value + 1f;
            CurrentLoad += 1f;
            number.text = " " + CurrentLoad;
        }

    }
}
