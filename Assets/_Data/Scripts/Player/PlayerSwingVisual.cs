using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwingVisual : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void SwingAnimation(String animationname)
    {
        animator.SetTrigger(animationname);
       
    }

}
