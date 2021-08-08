using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private PlacementIndicator placementIndicator;


    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        InvokeRepeating("Activate", 0, 6);

    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn, 
                placementIndicator.transform.position, placementIndicator.transform.rotation);
           
        }
        
    } 

    public void Activate() {

        GameObject obj = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    
   
}
