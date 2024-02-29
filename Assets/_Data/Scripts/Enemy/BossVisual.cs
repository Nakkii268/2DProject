using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVisual : EVisual
{

    [SerializeField] private EnemySO m_EnemySO;
    [SerializeField] Animator m_animator;
  
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = m_EnemySO.sprite;
    }

    /*public override void VisualUpdate()
    {
        if (DirectionCheck())
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }*/

    public void AttackAnimation(int index)
    {
        m_animator.SetTrigger("E_Attack" +index);
    }
    /*private bool DirectionCheck()
    {
        return(m_Position.x -  m_Preposition.x < 0 )?  true:  false;
    }*/
    public override void GetHitAnimator()
    {
        m_animator.SetTrigger("GetHit");
    }
    public void TeleportAnimation()
    {
        m_animator.SetTrigger("Teleport");
       
    }

    public override void PLayDeadAnimation()
    {
        throw new System.NotImplementedException();
    }
}
