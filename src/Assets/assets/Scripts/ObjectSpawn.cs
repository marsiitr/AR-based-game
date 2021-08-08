using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject Boar;
    bool level1 = false;
    int t1=6;

    private PlacementIndicator placementIndicator;


    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        InvokeRepeating("Activate", 2, t1);
        InvokeRepeating("Activate1", 5, 10);
    }

    void Update()
    {

        if (ScoreScript.scoreValue >= 150)
        {
            t1 = 5;
            level1 = true;
        }
        
    } 

    public void Activate()
    {
        /*for (int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(objectToSpawn,
                    placementIndicator.transform.position + new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f)), placementIndicator.transform.rotation);
        }*/
        
        
            GameObject obj = Instantiate(objectToSpawn,
                       placementIndicator.transform.position + new Vector3(Random.Range(-1.5f, 1.5f), 0, Random.Range(-1.5f, 1.5f)), placementIndicator.transform.rotation);
       
       /* else
        {
            GameObject obj1 = Instantiate(objectToSpawn,
                       placementIndicator.transform.position + new Vector3(Random.Range(-1.5f, 1.5f), 0, Random.Range(-1.5f, 1.5f)), placementIndicator.transform.rotation);
            
            
        }*/
    }

    public void Activate1()
    {
        if (level1)
        {
            GameObject obj2 = Instantiate(Boar,
                           placementIndicator.transform.position + new Vector3(Random.Range(-1.5f, 1.5f), 0, Random.Range(-1.5f, 1.5f)), placementIndicator.transform.rotation);
        }

    }
    
   
}
