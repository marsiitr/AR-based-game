/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
//using UnityEngine.XR.ARSubsystems;

//[RequiredComponent(typeof(ARRaycastManager))]

public class objectplacement : MonoBehaviour
{
     private ARRaycastManager raycastManager;
     private GameObject spawnedObject;

     [serializeField]
     private GameObject placeableprefab;

     static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

     private void Awake()
     {
          raycastManager = GetComponent<ARRaycastManager>();
     }

     bool TryGetTouchPosition(out Vector2 touchPosistion)
     {
          if(Input.touchCount > 0)
          {
                touchPosition = Input.GetTouch(0).position;
                return true;
          }

          touchPosistion = default;
          return false;
     }

     private void Update()
     {
          if(!TryGetTouchPosition(out Vector2 touchPosition))
          {
                return;
          }
          if(raycastManager.Raycast(touchPosistion, s_Hits, TrackableType.planeWithinPolygon))
          {
                var hitPose = s_Hits[0].pose;
                if(spawnedObject == null)
                {
                    spawnedObject = Instantiate(placeableprefab, hitPose.position, hitPose.rotation);
                }
                else 
                {
                    spawnedObject.transform.position = hitPose.position;
                    spawnedObject.transform.rotation = hitPose.rotation;
                }
          }
     }
}*/
