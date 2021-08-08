using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]*/

public class RandomFlyer : MonoBehaviour
{
   
    public float walk_Speed = 5f;
    void Start()
    {
        InvokeRepeating("Change", 0, 4);
    }

    void Update()
    {
        Patrol();
    }
    void Patrol()
    {
        transform.Translate(Vector3.forward * 5*Time.deltaTime);
        //this.transform.Rotate(new Vector3(0, Random.Range(0, 360),Random.Range(0,360)));
    }
    void Change()
    {
        this.transform.Rotate(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
    }
   /* float angle, radius = 10;
    float angleSpeed = 2;
    float radialSpeed = 0.5f;

    void Update()
    {
        angle += Time.deltaTime * angleSpeed;
        radius = Random.Range(-5, 5);
        float x = radius * Mathf.Cos(Mathf.Deg2Rad * angle);
        float z = radius * Mathf.Sin(Mathf.Deg2Rad * angle);
        float y = transform.position.y;

        transform.position = new Vector3(x, y, z);
    }*/
}