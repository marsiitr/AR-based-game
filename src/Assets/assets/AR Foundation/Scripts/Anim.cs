using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{

    private void Update()
    {
  

    }


    public void playanimation()
    {
        Debug.Log("hy");
       GetComponent<UnityEngine.Animation>().Play("jumping");
        // StartCoroutine(delay());
      //  GetComponent<Animation>().Play("jumping");

        // GameObject obj = Instantiate(prefab) as GameObject;
        // anim = obj.GetComponent<Animation>();
    }

    void stand()
    {
        GetComponent<UnityEngine.Animation>().Play("jumping");

    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2.5f);
       // stand();
    }



}
