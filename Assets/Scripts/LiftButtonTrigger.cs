using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButtonTrig : MonoBehaviour
{
    private Animator animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("isTriggered");
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("isTriggered");
        }
    }
}
