using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{

    [SerializeField] EVisual enemyVisual;
    [SerializeField] private EnemySO enemySO;
    public float Dmg;
    public float Speed;
    public float Hp;
    public float attackRange;
    private int coinDrop;
    public float activeRange;
    public float attackSpeed;
    [SerializeField] private float currentHp;
    // [SerializeField] private float attackInterval;
    [SerializeField] private float attackCooldown = 0f;
    //[SerializeField] private EnemyAttack enemyAttack;
    [SerializeField] private Attack enemyAttack;
    [SerializeField] private bool isAlive;
    [SerializeField] public Player player;
    public enum State
    {
        Idle,
        Chasing,
        Attack
    }
    private State state;

    
    public override event EventHandler<IHasHpBar.OnHpChangeEventArgs> OnHpChange;

    private void Awake()
    {
        GetStat();

    }
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        state = State.Idle;
        isAlive = true;

    }
    private void Update()
    {
        StateUpdate();
        VisualUpdate();

        //check alive
        if (!isAlive)
        {
            DestroySelf();
        }

    }
    public override void StateUpdate()
    {
        switch (state)
        {
            case State.Idle:
                if (Vector3.Distance(player.transform.position, transform.position) < activeRange)
                {
                    state = State.Chasing;
                }
                break;
            case State.Chasing:
                if (FollowTarget())
                {
                    transform.position = Vector2.Lerp(transform.position, new Vector2(player.transform.position.x - attackRange / 2, player.transform.position.y - attackRange / 2), Speed * Time.deltaTime);

                }
                else
                {

                    state = State.Idle;
                }
                if (Vector3.Distance(transform.position,    player.transform.position) <= attackRange)
                {
                    transform.position = transform.position;
                    state = State.Attack;
                }

                break;

            case State.Attack:
                if (IsInAttackRange())
                {
                    
                        int randAttack = UnityEngine.Random.Range(0, 3);
                    if (attackCooldown > (1 / attackSpeed))
                    {
                        attackCooldown = 0f;
                        if (randAttack == 0)
                        {
                            MoveToTarget(3, 0);
                        }
                        else if (randAttack == 1)
                        {
                            {

                                MoveToTarget(2, 0);
                            }
                            StartCoroutine(delayedAttack(randAttack));
                        }
                        else
                        {
                            enemyAttack.RangeAttack(0);
                            Debug.Log("ranged Attack");
                        }
                    }
                    else
                    {
                        attackCooldown += Time.deltaTime;
                    }
                    
                    
                }
                else
                {
                    state = State.Chasing;
                }
                break;
        }
    }

    public override void VisualUpdate()
    {
        if (DirectionCheck())
        {
            transform.localScale = new Vector3(-1, 1, 1);
            GetComponentInChildren<EnemyHpBarUI>().transform.localScale = transform.localScale;
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
            GetComponentInChildren<EnemyHpBarUI>().transform.localScale = transform.localScale;

        }
    }
    public override void DealDamage(IReceiveDamage receiveDmg, float dmg)
    {
        receiveDmg.ReduceHp(dmg);
    }

    public override void ReduceHp(float dmg)
    {
        currentHp -= dmg;
        OnHpChange?.Invoke(this, new IHasHpBar.OnHpChangeEventArgs
        {
            HpNormalized = currentHp / Hp
        });
        if (currentHp <= 0f)
        {
            isAlive = false;
        }
        enemyVisual.GetHitAnimator();
    }
    public override void GetStat()
    {
        this.Hp = enemySO.Hp;
        this.currentHp = enemySO.Hp;
        this.Dmg = enemySO.Dmg;
        this.Speed = enemySO.Speed;
        this.coinDrop = enemySO.coinDrop;
        this.attackRange = enemySO.attackRange;
        this.attackSpeed = enemySO.attackSpeed;
        this.activeRange = enemySO.activeRange;

    }

    private bool FollowTarget()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < activeRange)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool IsInAttackRange()
    {
        return (Vector3.Distance(player.transform.position, transform.position) < attackRange) ? true : false;

    }
    public override void DestroySelf()
    {

        gameObject.SetActive(false);
        DropCoin();
    }
    private void DropCoin()
    {
        player.CollectCoin(coinDrop);
    }

    public void MoveToTarget(float a, float b)
    {
        int tempRan = UnityEngine.Random.Range(0, 2);
        if (tempRan == 0)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x - a, player.transform.position.y - b, player.transform.position.z), 1);

        }
        else if (tempRan == 1)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x + a, player.transform.position.y - b, player.transform.position.z), 1);

        }
        Debug.Log("Moved");
    }
    private bool DirectionCheck()
    {
        return (transform.position.x - player.transform.position.x < 0) ? true : false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
    IEnumerator delayedAttack(int i)
    {
        yield return new WaitForSeconds(.5f);
        enemyAttack.MeleeAttack(i);
    }

    public override void PlayAnimationAndDead()
    {
        throw new NotImplementedException();
    }

    public override bool IsAlive()
    {
        return isAlive;
    }
}
