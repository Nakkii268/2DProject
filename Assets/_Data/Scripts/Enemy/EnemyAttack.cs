using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : Attack
{
    [SerializeField] NormalEnemy m_Enemy;
    [SerializeField] EnemyVisual enemyVisual;
    public float attackRange;
    public float attackDmg ;

    public LayerMask playerLayer;
    [SerializeField] public Transform attackPoint;
    //[SerializeField] public Player player;
    private float knockBackForce = .2f;
    private Player player;

    private void Start()
    {
        //player = GameObject.Find("Player").GetComponent<Player>();

        player = Player.Instance;
        attackDmg = m_Enemy.Dmg;
        attackRange = m_Enemy.attackRange;
    }
    public override void MeleeAttack(int indx)
    {
            enemyVisual.AttackAnimation();
        
        Collider2D hit = Physics2D.OverlapCircle(attackPoint.position, attackRange, playerLayer);
        if (hit.tag == "Player")
        {
            player.DealDamage(m_Enemy.player,attackDmg);
            Debug.Log("hit");
            Knockback(hit.transform);
        }
       
    }

    public void Knockback(Transform enemy)
    {
        Vector2 knockBackPos = enemy.position + (enemy.position - transform.position).normalized * knockBackForce;
        enemy.position = Vector2.Lerp(enemy.position, knockBackPos, 2f);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public override void RangeAttack(int indx)
    {
        throw new System.NotImplementedException();
    }
}
