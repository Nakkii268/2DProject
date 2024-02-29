using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_PlayerAttack : Attack
{
    [SerializeField] private PlayerSwingVisual _playerSwingVisual;

    public float attackRange = 2f;
    public float attackDmg = 1;
    public LayerMask enemyLayer;
    [SerializeField] public Transform attackPoint;
    [SerializeField] public Transform hitbox1;
    private float knockBackForce = .2f;
    public float duration = 1f;
    public int attackIndex;
    private Player player;

    private void Start()
    {
        player = Player.Instance;
        _playerSwingVisual = GameObject.Find("PlayerAttackDir").GetComponentInChildren<PlayerSwingVisual>();
    }
    private enum State
    {
        idleAttack,
        entryAttack,
        comboAttack,
        finishAttack
    }

    [SerializeField] private State state;
    private void Update()
    {
       
        switch (state)
        {
            case State.idleAttack:
                if (player.attackIndex == 1)
                {
                    StartCoroutine(AttackDelay(1));
                    state = State.entryAttack;
                    _playerSwingVisual.SwingAnimation("Swing");
                    player.comboDurantion = 1f;
                    Debug.Log(state.ToString());
                }
                break;

            case State.entryAttack:


                if (player.comboDurantion > 0)
                {
                    player.comboDurantion -= Time.deltaTime;
                    if (player.attackIndex == 2)
                    {
                        StartCoroutine(AttackDelay(2));
                        state = State.comboAttack;
                        _playerSwingVisual.SwingAnimation("Attack1");

                        player.comboDurantion = 1f;

                        Debug.Log(state.ToString());

                    }
                }
                else
                {
                    player.attackIndex = 0;
                    player.comboDurantion = 1f;
                    state = State.idleAttack;
                }
                break;

            case State.comboAttack:
                if (player.comboDurantion > 0)
                {
                    player.comboDurantion -= Time.deltaTime;

                    if (player.attackIndex == 0)
                    {
                        StartCoroutine(AttackDelay(0));
                        state = State.finishAttack;
                        _playerSwingVisual.SwingAnimation("Attack2");

                        player.comboDurantion = 1f;

                        Debug.Log(state.ToString());

                    }
                }
                else
                {
                    player.attackIndex = 0;
                    player.comboDurantion = 1f;
                    state = State.idleAttack;
                }
                break;

            case State.finishAttack:
                if (player.comboDurantion > 0)
                {
                    player.comboDurantion -= Time.deltaTime;

                    state = State.idleAttack;
                    player.comboDurantion = 1f;

                    Debug.Log(state.ToString());
                }

                break;

        }

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        Gizmos.DrawWireSphere(hitbox1.position, 3f);
    }

    public override void MeleeAttack(int attackIndx)
    {
        attackDmg = player.Dmg;

        if (attackIndx == 2 || attackIndx == 1)
        {
           
            Collider2D[] hit = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
            for (int i = 0; i < hit.Length; i++)
            {

                if (hit[i].tag == "Enemy")
                {
                    Enemy enemy = hit[i].gameObject.GetComponent<Enemy>();
                    player.DealDamage(enemy, attackDmg);
                    Knockback(hit[i].transform);
                    if (!enemy.IsAlive())
                    {
                        enemy.PlayAnimationAndDead();
                    }
                }
            }

        }
        else if (attackIndx == 0)
        {
            
                Collider2D[] hit = Physics2D.OverlapCircleAll(hitbox1.position, 3f, enemyLayer);
                for (int i = 0; i < hit.Length; i++)
                {

                    if (hit[i].tag == "Enemy")
                    {
                        Enemy enemy = hit[i].gameObject.GetComponent<Enemy>();
                        player.DealDamage(enemy, attackDmg * 1.5f);
                        Knockback(hit[i].transform);
                    if (!enemy.IsAlive())
                    {
                        enemy.PlayAnimationAndDead();
                    }
                }
                }
            
        }
    } 

    public void Knockback(Transform enemy) 
    {
        Vector2 knockBackPos = enemy.position + (enemy.position - player.transform.position).normalized * knockBackForce;
        enemy.position =  Vector2.Lerp(enemy.position, knockBackPos,1f);
    }

    IEnumerator AttackDelay(int attackIndex)
    {

        yield return new WaitForSeconds(.1f);
        MeleeAttack(attackIndex);
    }

    public override void RangeAttack(int indx)
    {
        throw new System.NotImplementedException();
    }
}
