using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio0 : MonoBehaviour
{
   void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
