using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAttack : MonoBehaviour
{
    private WeaponManager weapon_Manager;
    //public GameObject Cam;

    public float fireRate = 15f;
    private float nextTimeToFire;
    public float damage = 200f;
    //public GameObject Blood;

    private Animator zoomCameraAnim;
    private bool zoomed;

    private Camera mainCam;

    private GameObject crosshair;

    private bool is_Aiming;
    [SerializeField]
    private GameObject arrow_Prefab;
    public float deactivate_Timer = 3f;

    [SerializeField]
    private Transform arrow_Bow_StartPosition;

    public bool InfiniteDecal;
    public Light DirLight;
    public bool isVR = true;
    public GameObject BloodAttach;
    public GameObject[] BloodFX;
    public int Score;
    bool Arrow = false;


    Transform GetNearestObject(Transform hit, Vector3 hitPos)
    {
        var closestPos = 100f;
        Transform closestBone = null;
        var childs = hit.GetComponentsInChildren<Transform>();

        foreach (var child in childs)
        {
            var dist = Vector3.Distance(child.position, hitPos);
            if (dist < closestPos)
            {
                closestPos = dist;
                closestBone = child;
            }
        }

        var distRoot = Vector3.Distance(hit.position, hitPos);
        if (distRoot < closestPos)
        {
            closestPos = distRoot;
            closestBone = hit;
        }
        return closestBone;
    }

    public Vector3 direction;
    int effectIdx;


    void Start()
    {
        Invoke("DeactivateGameObject", deactivate_Timer);
    }
    private void Awake()
    {
        weapon_Manager = GetComponent<WeaponManager>();
        zoomCameraAnim = transform.Find(Tags.LOOK_ROOT).transform.Find(Tags.ZOOM_CAMERA).GetComponent<Animator>();

        crosshair = GameObject.FindWithTag(Tags.CROSSHAIR);

        mainCam = Camera.main;
    }
  
    // Update is called once per frame
   /* void Update()
    {
       // WeaponShoot();
        BulletFired();
    }*/

    public void WeaponShoot()
    {
        if (weapon_Manager.GetCurrentSelectedWeapon().tag == Tags.AXE_TAG)
        {
           
            weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
            Arrow = false;
            
            BulletFired();
     
        }

        else if ( weapon_Manager.GetCurrentSelectedWeapon().bulletType == WeaponBulletType.BULLET)
        {
            
            weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
            Arrow = false;
         
            BulletFired();
        }
        else
        {
            //if(is_Aiming)
            //{
          
                weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

               // if(weapon_Manager.GetCurrentSelectedWeapon().bulletType == WeaponBulletType.ARROW)
                {
                    //throw arrow
                    GameObject arrow = Instantiate(arrow_Prefab);
                    arrow.transform.position = arrow_Bow_StartPosition.position;
                    arrow.GetComponent<ArrowandBowScript>().Launch(mainCam);
                    Arrow = true;

                    BulletFired();

                }
            //}
        }
    }

   public void ZoomInAndOut()
    {
        if(weapon_Manager.GetCurrentSelectedWeapon().weapon_Aim == WeaponAim.AIM)
        {
            if(Input.GetMouseButtonDown(1))
            {
                zoomCameraAnim.Play(AnimationTags.ZOOM_IN_ANIM);
                crosshair.SetActive(false);
            }
            if (Input.GetMouseButtonDown(1))
            {
                zoomCameraAnim.Play(AnimationTags.ZOOM_OUT_ANIM);
                crosshair.SetActive(true);
            }
        }
        if(weapon_Manager.GetCurrentSelectedWeapon().weapon_Aim == WeaponAim.SELF_AIM)
        {
            if(Input.GetMouseButtonDown(1))
            {
                weapon_Manager.GetCurrentSelectedWeapon().Aim(true);
                is_Aiming = true;
            }
            if (Input.GetMouseButtonUp(1))
            {
                weapon_Manager.GetCurrentSelectedWeapon().Aim(false);
                is_Aiming = false;
            }
        }
    }
 void BulletFired()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit))
        //if(Physics.Raycast(Cam.transform.position,Cam.transform.forward, out hit))   
        {
            //if (hit.transform.tag == Tags.ENEMY_TAG)
            if (hit.transform.name == "Cannibal 1 Variant 1(Clone)" || hit.transform.name == "Cannibal 1 Variant 1" || hit.transform.name == "Boar" || hit.transform.name == "Boar(Clone)")
            {
                hit.transform.GetComponent<Kill>().ApplyDamage(damage);
                //Instantiate(Blood, hit.transform.position + new Vector3(0f,1f,0f), Quaternion.identity);
                // var randRotation = new Vector3(0, Random.value * 360f, 0);
                // var dir = CalculateAngle(Vector3.forward, hit.normal);
                float angle = Mathf.Atan2(hit.normal.x, hit.normal.z) * Mathf.Rad2Deg + 180;

                //var effectIdx = Random.Range(0, BloodFX.Length);
                if (effectIdx == BloodFX.Length) effectIdx = 0;

                var instance = Instantiate(BloodFX[effectIdx], hit.point, Quaternion.Euler(0, angle + 90, 0));
                effectIdx++;

                var settings = instance.GetComponent<BFX_BloodSettings>();
                settings.DecalLiveTimeInfinite = InfiniteDecal;
                settings.LightIntensityMultiplier = DirLight.intensity;

                var nearestBone = GetNearestObject(hit.transform.root, hit.point);
                if (nearestBone != null)
                {
                    var attachBloodInstance = Instantiate(BloodAttach);
                    var bloodT = attachBloodInstance.transform;
                    bloodT.position = hit.point;
                    bloodT.localRotation = Quaternion.identity;
                    bloodT.localScale = Vector3.one * Random.Range(0.75f, 1.2f);
                    bloodT.LookAt(hit.point + hit.normal, direction);
                    bloodT.Rotate(90, 0, 0);
                    bloodT.transform.parent = nearestBone;
                    Destroy(attachBloodInstance, 20);
                }

                if (!InfiniteDecal) Destroy(instance, 20);

            }
            if (Arrow)
            {
                Instantiate(arrow_Prefab, hit.transform.position, Quaternion.identity);
            }
            if (hit.transform.GetComponent<Kill>().health <= -50)
            {
                Destroy(hit.transform.gameObject);
                ScoreScript.scoreValue += 10;
                Score += 10;
            }

        }
        else
        {
            return;
        }
      
                
                
            }

        }
 