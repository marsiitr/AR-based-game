using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Walk(bool walk)
    {
        anim.SetBool(AnimationTags.WALK_PARAMETER, walk);
    }

    public void Run(bool run)
    {
        anim.SetBool(AnimationTags.RUN_PARAMETER, run);
    }

    public void Attack()
    {
        anim.SetTrigger(AnimationTags.ATTACK_TRIGGER);
    }
   /* public void Attack(bool attack)
    {
        anim.SetBool(AnimationTags.ATTACK_TRIGGER, attack);
    }*/

    public void Dead()
    {
        anim.SetTrigger(AnimationTags.DEAD_TRIGGER);
    }
    // Start is called before the first frame update
   
}
