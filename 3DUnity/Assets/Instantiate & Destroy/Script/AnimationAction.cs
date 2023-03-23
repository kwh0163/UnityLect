using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    public void Dance()
    {
        animator.Play("Gangnam");
    }

    public void Attack()
    {
        animator.Play("Attack");
    }
}
