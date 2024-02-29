using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class BossAttack : Attack
{
    [SerializeField] Boss m_Boss;
    [SerializeField] BossVisual BossVisual;
    [SerializeField] Transform rangedAttack;
    public float attackDmg;
    
    public LayerMask playerLayer;
    [SerializeField] public Transform attackPoint1;
    [SerializeField] public Transform attackPoint2;
    [SerializeField] public Transform attackPoint3;
   private Player player;
    private float knockBackForce = .2f;


    private void Start()
    {
        // player = GameObject.Find("Player").GetComponent<Player>();

        player = Player.Instance;
        attackDmg = m_Boss.Dmg;
        
    }
    public override void MeleeAttack(int indx)
    {
       if (indx == 0)
        {
            BossVisual.TeleportAnimation();

          

           
            BossVisual.AttackAnimation(0);
        Collider2D hit = Physics2D.OverlapCircle(attackPoint1.position,1f, playerLayer);
            if (hit.tag == "Player" & hit != null)
        {
                StartCoroutine(DamageDelay(attackDmg));
                
                //Player.Instance.DealDamage(m_Enemy.player, attackDmg);
            Debug.Log("hit");
            Knockback(hit.transform);
        }
        //}

         }
        if (indx == 1)
         {   
             BossVisual.TeleportAnimation();

             

             BossVisual.AttackAnimation(1);
             Collider2D hit = Physics2D.OverlapCircle(attackPoint2.position, 2f, playerLayer);
            //for (int i = 0; i < hit.Length; i++)
            //{
            if (hit.tag == "Player" && hit!=null)
            {
                     StartCoroutine(DamageDelay(attackDmg));
                //Player.Instance.DealDamage(m_Enemy.player, attackDmg);

                Debug.Log("hit");

            }
           
        }

        //}


    }

    public void Knockback(Transform enemy)
    {
        Vector2 knockBackPos = enemy.position + (enemy.position - transform.position).normalized * knockBackForce;
        enemy.position = Vector2.Lerp(enemy.position, knockBackPos, 2f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPoint1.position, 1);
        Gizmos.DrawWireSphere(attackPoint2.position, 2);
    }
 
    IEnumerator DamageDelay(float dmg)
    {
        yield return new WaitForSeconds(.5f);
        player.DealDamage(m_Boss.player, dmg);
    }

    public override void RangeAttack(int indx)
    {
       Transform B_RangedAttack =  Instantiate(rangedAttack, gameObject.transform);
        B_RangedAttack.position = attackPoint3.position;
        B_RangedAttack.transform.rotation = Quaternion.Euler(new Vector3(attackPoint3.rotation.x, attackPoint3.rotation.y, attackPoint3.rotation.z));

    }
}
