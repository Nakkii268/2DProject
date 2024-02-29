using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    [SerializeField] private Animator animator;
    //[SerializeField] private Player player;

    private void Start()
    {
        Player.Instance.OnGetHit += Player_OnGetHit;
    }

    private void Player_OnGetHit(object sender, System.EventArgs e)
    {
        animator.SetTrigger("GetHit");
    }

    private void Update()
    {
        UpdateVisual();
    }
    private void UpdateVisual()
    {
        Vector2 moveDir =GameInput.Instance.GetMovementVectorNormalized();
        
     if(moveDir != Vector2.zero )
        {
        if(moveDir.x > 0)
        {
            Player.Instance.transform.localScale = new Vector3(1, 1, 1);
            
        }
        else if(moveDir.x < 0)
        {
           Player.Instance.transform.localScale = new Vector3(-1, 1, 1);
          
        }
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
        



    }
}
