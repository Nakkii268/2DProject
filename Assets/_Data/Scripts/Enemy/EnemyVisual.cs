using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisual : EVisual
{
   
    [SerializeField] private EnemySO m_EnemySO;
    [SerializeField] Animator m_animator;
    
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = m_EnemySO.sprite;
    }



    public void AttackAnimation()
    {
        m_animator.SetTrigger("E_Attack");
    }
    /*private bool DirectionCheck()
    {
        return(m_Position.x -  m_Preposition.x < 0 )?  true:  false;
    }*/
    public override void GetHitAnimator()
    {
        m_animator.SetTrigger("GetHit");
    }

    public override void PLayDeadAnimation()
    {
        int num = Random.Range(0, 2);
        if(num == 0) {
            m_animator.Play("E_Dead");
            Debug.Log("dead");


        }
        else
        {
            m_animator.Play("E_Dead1"); ;
            Debug.Log("dead1");

        }
    }
}
