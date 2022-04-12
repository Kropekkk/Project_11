using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public ParticleSystem blood;
    public Animator animator;

    private bool isAlive = true;

    public void Hit(int value)
    {
        health -= value;

        if(health<=0)
        {
            Die();

            return;
        }

        blood.Play();
    }

    public bool IsAlive()
    {
        return isAlive;
    }

    private void Die()
    {
        isAlive = false;
        animator.SetBool("Dead", true);   
    }
}