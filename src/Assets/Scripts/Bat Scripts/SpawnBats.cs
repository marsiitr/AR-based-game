using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBats : MonoBehaviour
{
    int j = 20;
    public GameObject Bat;

    void Start()
    {

            InvokeRepeating("Spawn", 0, 5);
    }

    public void Spawn()
    {
        for (int i = 0; i < j; i++)
        {
            Instantiate(Bat, GameObject.FindWithTag("MainCamera").transform.position+ new Vector3(Random.Range(-5, 5),Random.Range(-0.3f,0.3f), Random.Range(-5, 5)), Quaternion.identity);
        }
        j--;
    }
}
