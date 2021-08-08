using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawn : MonoBehaviour
{
    //public GameObject Axe;
    /*public GameObject Revolver;
    public GameObject Shotgun;
    public GameObject WoodenBow;*/
   // public GameObject Base;
    /*public GameObject placementIndicator;
    [SerializeField]
    private Vector2 _start = Vector2.zero;
    [SerializeField]
    private Vector2 _end = Vector2.zero;
    [SerializeField]
    private float _speed = 1f;
    private new Vector3 Pos;
    */
    
  // void Update()
   // {
       /* float t = Mathf.PingPong(Time.time, _speed) / _speed;

        Axe.transform.position = Vector2.Lerp(_start, _end, t);
        Revolver.transform.position = Vector2.Lerp(_start, _end, t);
        Shotgun.transform.position = Vector2.Lerp(_start, _end, t);
        WoodenBow.transform.position = Vector2.Lerp(_start, _end, t);*/

   // }
   
  
    /*public void spawn()
    {
        
        //Pos = placementIndicator.transform.position + new Vector3(Random.Range(-10, 10), 0.25f, Random.Range(-10, 10));
        float y = GameObject.FindWithTag("Plane").transform.position.y + GameObject.FindWithTag("MainCamera").transform.position.y+0.1f;
        //Instantiate(Axe, new Vector3(Random.Range(-10, 10), y, Random.Range(-10, 10)), Quaternion.identity);
        //GameObject.Find("Axe_(Clone)").transform.Translate(0, 0, 0 * Time.deltaTime);
        //Instantiate(Axe,Pos , Quaternion.identity);
        //Pos = placementIndicator.transform.position + new Vector3(Random.Range(-10, 10), 0.25f, Random.Range(-10, 10));
        //Instantiate(Base, Axe.transform.position + new Vector3(0f, -0.5f, 0f), Quaternion.identity);
        Instantiate(Shotgun, new Vector3(Random.Range(-10, 10), y, Random.Range(-10, 10)), Quaternion.identity);
        GameObject.Find("Shotgun_(Clone)").transform.Translate(0, 0, 0 * Time.deltaTime);
        //Instantiate(Shotgun, Pos, Quaternion.identity);
        //Pos = placementIndicator.transform.position + new Vector3(Random.Range(-10, 10), 0.25f, Random.Range(-10, 10));
        //(Base, Shotgun.transform.position + new Vector3(0f, -0.5f, 0f), Quaternion.identity);
        Instantiate(Revolver, new Vector3(Random.Range(-10, 10), y, Random.Range(-10, 10)), Quaternion.identity);
        GameObject.Find("Revolver_(Clone)").transform.Translate(0, 0, 0 * Time.deltaTime);
        // Instantiate(Revolver, Pos, Quaternion.identity);
       // Pos = placementIndicator.transform.position + new Vector3(Random.Range(-10, 10), 0.25f, Random.Range(-10, 10));
        //Instantiate(Base, Revolver.transform.position + new Vector3(0f, -0.5f, 0f), Quaternion.identity);
        Instantiate(WoodenBow, new Vector3(Random.Range(-10, 10), y, Random.Range(-10, 10)), Quaternion.identity);
        GameObject.Find("WoodenBow_(Clone)").transform.Translate(0, 0, 0 * Time.deltaTime);
        //Instantiate(WoodenBow, Pos, Quaternion.identity);
        //Instantiate(Base, WoodenBow.transform.position + new Vector3(0f, -0.5f, 0f), Quaternion.identity);
    }*/

}
