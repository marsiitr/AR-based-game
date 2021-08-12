using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public enum EnemyState
{
    PATROL,
    CHASE,
    ATTACK,
    DEAD
}
public class EnemyController : MonoBehaviour
{
    public EnemyAnimator enemy_Anim;
    //public NavMeshAgent navAgent;
    public HealthBar healthBar;
    public float health;
    public EnemyAudio enemyAudio;

   // public static int CurrentHealth = 100;
    //public GameObject[] life;
    //Transform target;
    //public Slider slider;
    public EnemyState enemy_State;

    public float walk_Speed = 0.5f;
    public float run_Speed = 4f;

    public float chase_Distance = 7f;
    private float current_Chase_Distance;
    public float attack_Distance = 1.5f;
    public float chase_After_Attack_Distance = 2f;
    public float patrol_Radius_Min = 20f, patrol_Radius_Max = 60f;

    public float patrol_For_this_Time = 15f;
    public float patrol_Timer;

    public float wait_Before_Attack = 2f;
    private float attack_Timer;

    public GameObject attack_Point;
    public float current_speed = 0;

    //public GameObject attack_Point;

    private EnemyAudio enemy_Audio;
    int down=0;


   


    //public Vector3 Cam = new Vector3(0f,0f,0f);
    Transform target ;

    void Awake()
    {
        //enemy_Anim = GetComponent<EnemyAnimator>();
        //navAgent = GetComponent<NavMeshAgent>();
        //healthBar = GetComponent<Canvas>().GetComponentsInChildren<HealthBar>();
        target = GameObject.FindWithTag("MainCamera").transform;
        enemy_Audio = GetComponentInChildren<EnemyAudio>();
        //GetDamage = GameObject.FindWithTag("Damage");
        //healthBar = GameObject.Find("Canvas").GetComponent("HealthBar") as HealthBar;
        //life[0] = GameObject.Find("Canvas").GetComponent("Life").GetChild(0) as l1;
    }
    // Start is called before the first frame update
    void Start()
    {
        enemy_State = EnemyState.PATROL;

        patrol_Timer = patrol_For_this_Time;

        attack_Timer = wait_Before_Attack;

        current_Chase_Distance = chase_Distance;
        

       // i = 2;

    }

    // Update is called once per frame
    void Update()
    {
        
            Dead();
        
        if (enemy_State == EnemyState.PATROL)
        {
            Patrol();
        }
        if (enemy_State == EnemyState.CHASE)
        {
            Chase();
        }
        if (enemy_State == EnemyState.ATTACK)
        {
            
            Attack();
            
        }
  
       // healthBar.SetHealth(CurrentHealth);
       // ImproveHealth();
    }


    void Patrol()
    {
        //navAgent.isStopped = true;
        //navAgent.speed = walk_Speed;
        this.transform.Translate(0, 0, walk_Speed * Time.deltaTime);
        current_speed = walk_Speed;

        patrol_Timer += Time.deltaTime;
        if (patrol_Timer > patrol_For_this_Time)
        {
            //SetNewRandomDestination();
            this.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));
            patrol_Timer = 0f;
        }

        //if (navAgent.velocity.sqrtMagnitude > 0)
        //if(navAgent.velocity.magnitude>0)
        if(current_speed != 0)
        {
            enemy_Anim.Walk(true);
        }
        else
        {
            enemy_Anim.Walk(false);
        }
        if (Vector3.Distance(transform.position, target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f)) <= chase_Distance )
        {
            enemy_Anim.Walk(false);

            enemy_State = EnemyState.CHASE;

            enemy_Audio.Play_ScreamSound();

        }

    }

    void Chase()
    {
        //navAgent.isStopped = false;
        //navAgent.speed = run_Speed;
        this.transform.Translate(0, 0, run_Speed * Time.deltaTime);
        current_speed = run_Speed;
        //navAgent.SetDestination(Cam);
        this.transform.LookAt(target.position-new Vector3(0f,target.position.y-this.transform.position.y,0f));
        //if (navAgent.velocity.sqrtMagnitude > 0)
        //if(navAgent.velocity.magnitude>0)
        Text Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
        Caption.text = " ";
        if(current_speed!=0)
        {
            enemy_Anim.Run(true);
        }
        else
        {
            enemy_Anim.Run(false);
        }

        if (Vector3.Distance(transform.position, target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f)) <= attack_Distance)
        {
            enemy_Anim.Run(false);
            enemy_Anim.Walk(false);
            enemy_State = EnemyState.ATTACK;
           // healthBar.TakeDamage(10);
            //healthBar.slider.value = CurrentHealth;
            if (chase_Distance != current_Chase_Distance)
            {
                chase_Distance = current_Chase_Distance;
            }
        }

        else if (Vector3.Distance(transform.position, target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f)) > chase_Distance)
        {
            enemy_Anim.Run(false);

            enemy_State = EnemyState.PATROL;

            patrol_Timer = patrol_For_this_Time;

            if (chase_Distance != current_Chase_Distance)
            {
                chase_Distance = current_Chase_Distance;
            }
        }

    }

    void Attack()
    {
        //navAgent.velocity = Vector3.zero;
        //navAgent.isStopped = true;
        this.transform.Translate(0, 0, 0 * Time.deltaTime);
        attack_Timer += Time.deltaTime;

        if (attack_Timer > wait_Before_Attack)
        {
            this.transform.LookAt(target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f));
            enemy_Anim.Attack();
            //enemy_Anim.Attack();
            healthBar.TakeDamage(5);
            


            //healthBar.slider.value = CurrentHealth;
            // TakeDamage(10);

            attack_Timer = 0f;

            enemy_Audio.Play_AttackSound();
        }
       

        if (Vector3.Distance(transform.position, target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f)) >= attack_Distance + chase_After_Attack_Distance)
        {
            enemy_State = EnemyState.CHASE;
            //GetDamage.SetActive(false);
            this.transform.LookAt(target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f));
        }

    }

    void Dead()
    {
        health = this.GetComponent<Kill>().health;
        if (health < 100 && health > 0)
        {
            if (Vector3.Distance(transform.position, target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f)) > chase_Distance)
            {
                this.transform.LookAt(target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f));
                enemy_Anim.Walk(false);
                this.transform.Translate(0, 0, run_Speed * Time.deltaTime);
                current_speed = run_Speed;
                //navAgent.SetDestination(Cam);
                this.transform.LookAt(target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f));
                //if (navAgent.velocity.sqrtMagnitude > 0)
                //if(navAgent.velocity.magnitude>0)
                Text Caption = GameObject.FindWithTag("InstructionText").GetComponent<Text>();
                Caption.text = " ";
                if (current_speed != 0)
                {
                    enemy_Anim.Run(true);
                }
                else
                {
                    enemy_Anim.Run(false);
                }

            }
        }
        if (health <= 0)
        {
            //enemy_Anim.Attack(false);
            this.transform.Translate(0, 0, 0 * Time.deltaTime);
            if (down == 0)
            {
                this.transform.position -= new Vector3(0,this.transform.position.y+1.5f, 0);
                down++;
            }
            
            enemy_Anim.Dead();
        }
    }
    void Turn_On_AttackPoint()
    {
        attack_Point.SetActive(true);
    }
    void Turn_Off_AttackPoint()
    {
        if (attack_Point.activeInHierarchy)
        {
            attack_Point.SetActive(false);
        }
    }
    public EnemyState Enemy_State
    {
        get; set;
    }

   /* public void TakeDamage(int damage)
     {
         CurrentHealth -= damage;
         healthBar.SetHealth(CurrentHealth);
     }

    /*void Reduce()
    {

        // if (GameObject.FindWithTag("Enemy").GetComponent<EnemyController>().enemy_State == EnemyState.ATTACK)
        if (Vector3.Distance(GameObject.FindWithTag("Enemy").transform.position, target.position - new Vector3(0f, target.position.y - this.transform.position.y, 0f)) <= 2f)
        {
            TakeDamage(10);
        }

        healthBar.slider.value = CurrentHealth;

        if (CurrentHealth == 0)
        {
            life[i].SetActive(false);
            i--;
            if (i > 0 || i == 0)
            {
                healthBar.slider.value = 100;
                CurrentHealth += 100;
            }
        }
    }*/
   /* void ImproveHealth()
    {
        if (CurrentHealth == 0)
        {
            life[i].SetActive(false);
            i--;
            if (i > 0 || i == 0)
            {
                healthBar.slider.value = 100;
                CurrentHealth += 100;
            }
        }

    }*/
    /*public void TakeDamage(int damage)
    {

        CurrentHealth -= damage;

    }*/
    
}


