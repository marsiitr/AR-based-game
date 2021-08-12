
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BatScript : MonoBehaviour
{
    float maxDistance = 0.4f;
    

    void Update()
    {
        this.transform.LookAt(GameObject.FindWithTag("MainCamera").transform.position+new Vector3(0,Random.Range(-2,2),0));
        this.transform.Translate(0, 0, 15 * Time.deltaTime);
        float currentDistance = Vector3.Distance(GameObject.FindWithTag("MainCamera").transform.position, this.transform.position);
        if (currentDistance < maxDistance)
        {
            Destroy(gameObject);

        }
    }

}