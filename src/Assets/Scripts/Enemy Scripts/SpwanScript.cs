/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class SpwanScript : MonoBehaviour
{

 //{
    // public GameObject Cannibal;

   /* void Awake()
    {
        RaycastHit hit;

        for (int i = 0; i <20; i++)
        {
            Vector3 position = new Vector3(Random.Range(-100.0f, 100.0f), 0, Random.Range(-100.0f, 100.0f));
            //Do a raycast along Vector3.down -> if you hit something the result will be given to you in the "hit" variable
            //This raycast will only find results between +-100 units of your original"position" (ofc you can adjust the numbers as you like)
            Vector3 position1;
            position1.x = position.x;
            position1.y = position.y + 100;
            position1.z = position.z;
            if (Physics.Raycast(position1, Vector3.down, out hit, 200.0f))
            {
                Instantiate(Cannibal, hit.point, Quaternion.identity);
            }
            else
            {
                Debug.Log("there seems to be no ground at this position");
            }
        }
    }*/
    // public GameObject Grave;
    //public GameObject Zombie;
    // public Text TrackingText;
   // public GameObject Plane;
    // private Vector3 Pos;
    //public GameObject Pos;

  
    //private Vector3 RandomPos = new Vector3 (0,0,0);
    // Start is called before the first frame update
  //  void Start()
   // {
       // RandomPos.x += Random.Range(-100, 100);
        //RandomPos.y = 0;
        //RandomPos.z += Random.Range(-100, 100);
        //StartCoroutine(StartSpawning());
        //TrackingText.text = "Click on Start by pointing the camera to ground";
        //Pos = this.transform.position+Grave.transform.position;

        //InvokeRepeating("Spawn", 0, 5f);
  //  }

    // Update is called once per frame
   // void Update()
   // {
        
   // }
   /* IEnumerator StartSpawning()
    {
        Instantiate(Grave,RandomPos,Quaternion.identity);
        yield return RandomPos;
    }*/
     /* public void Spawn()
       {
               //Vector3 Pos = Grave.transform.position;
           TrackingText.text = "Starting...";
           new WaitForSeconds(5);
           Pos = this.transform.position;
           Pos.y = Grave.transform.position.y - 3;
               Instantiate(Zombie, Pos, Grave.transform.rotation);
               TrackingText.text = "Find Your Enemy";
               for (int i = 0; i < 20; i++)
               {
                   Pos.x = Random.Range(-20,20);
                   Pos.z = Random.Range(-20,20);
                   Instantiate(Zombie, Pos,Grave.transform.rotation);
                

               }
                       

       }*/
     /*private Vector3 RandomPointOnPlane(Vector3 position, Vector3 normal, float radius)
    {
        Vector3 randomPoint;

        do
        {
            randomPoint = Vector3.Cross(Random.insideUnitSphere, normal);
        } while (randomPoint == Vector3.zero);

        randomPoint.Normalize();
        randomPoint *= radius;
        randomPoint += position;

        return randomPoint;
    }

    public void Spwan()
    {
        TrackingText.text = "Starting...";
        new WaitForSeconds(5);
        Pos = Grave.transform.position;
        Vector3 normal = new Vector3(0, 1, 0);
        float r = 20;
        for (int i = 0; i < 20; i++)
        {
            Pos = RandomPointOnPlane(Pos, normal, r);
            Instantiate(Zombie, Pos, Quaternion.identity);
        }
        TrackingText.text = "Find Your Enemy";
        Destroy(Grave);

    }*/
   /* public GameObject[] Cannibal;
    public GameObject Grave;

    public void Spwan()
    {
       Vector3 Pos;
        Vector3 GravePos;
        //GravePos.x = this.transform.position.x+Grave.transform.position.x;
        //GravePos.y = this.transform.position.y+Grave.transform.position.y - 5;
        //GravePos.z = this.transform.position.z+Grave.transform.position.z;
        //Instantiate(Plane, GravePos, Grave.transform.rotation);
        for (int i = 0; i < 20; i++)
        {
           /*Cannibal[i].transform.position.x = Random.Range(-20,20) + Grave.transform.position.x;
            Cannibal[i].transform.position.y = Grave.transform.position.y - 5;
            Cannibal[i].transform.position.z = Grave.transform.position.z + Random.Range(-20, 20);*/
           /* Pos.x = Grave.transform.position.x + Random.Range(-20f, 20f);
            Pos.y = Grave.transform.position.y - 3;
            Pos.z = Grave.transform.position.z + Random.Range(-20f, 20f);
            Instantiate(Cannibal[i],Pos, Grave.transform.rotation);
        }
        Destroy(Grave);
    }
}*/



