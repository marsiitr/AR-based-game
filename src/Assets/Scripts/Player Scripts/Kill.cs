using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kill : MonoBehaviour
{
    public EnemyAnimator enemy_Anim;
    public NavMeshAgent navAgent;
    public EnemyController enemy_Controller;
    public float health = 100f;
    public EnemyAudio enemyAudio;
    

    void Awake()
    {
            enemy_Anim = GetComponent<EnemyAnimator>();
            enemy_Controller = GetComponent<EnemyController>();
            navAgent = GetComponent<NavMeshAgent>();
            enemyAudio = GetComponentInChildren<EnemyAudio>();
    }
    public void ApplyDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            StartCoroutine(DeadSound());
            
        }
    }
    IEnumerator DeadSound()
    {
        yield return new WaitForSeconds(0.3f);
        enemyAudio.Play_DeadSound();
    }
}
