using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowandBowScript : MonoBehaviour
{
    private Rigidbody myBody;

    public float speed = 20f;

    public float deactivate_Timer = 5f;

    public float damage = 15f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactivateGameObject", deactivate_Timer);
    }

    public void Launch(Camera mainCamera)
    {
        myBody.velocity = mainCamera.transform.forward * speed;

        transform.LookAt(transform.position + myBody.velocity);
    }
   
    void DeactivateGameObject()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider target)
    {
        // After we touch an enemy deactivate game object 
    }
}
