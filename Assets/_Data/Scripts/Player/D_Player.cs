using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using TreeEditor;
using UnityEngine;

public class D_Player : Player
{
    //public static  D_Player Instance { get;private  set; }
 
    //[SerializeField] internal GameInput _gameInput;

   //private BoxCollider2D boxCollider;
    //public event EventHandler OnInteractSomething;
    //public event EventHandler OnOpenShop;
   // public event EventHandler OnOpenBase;
   
    public override event EventHandler OnInteractSomething;
    public override event EventHandler OnOpenShop;
    public override event EventHandler OnOpenBase;
    public override event EventHandler OnOpenInventory;
    public override event EventHandler OnGetHit;
    public override event EventHandler<IHasHpBar.OnHpChangeEventArgs> OnHpChange;

    //public event EventHandler OnGetHit;
    //[SerializeField] private Weapon weapon;
    /* [SerializeField] public int attackIndex;
     [SerializeField] public float comboDurantion = 1f;
     [SerializeField] public float attackCooldown;

     //stat
     [SerializeField] public float Dmg;
     [SerializeField] public float speed;
     [SerializeField] public float attackSpeed;
     [SerializeField] public float currentHp;
     [SerializeField] public float HpMax;
     [SerializeField] public float coin;*/


    /*private void Awake()
    {
       if(Instance == null)
        {
            Instance = this;

        }
        else { Destroy(Instance.gameObject); }

      // _gameInput = GameInput.Instance;
    } */


    private void Start()
    {
 
        GameInput.Instance.OnAttackAction += GameInput_OnAttackAction;
        boxCollider = GetComponent<BoxCollider2D>();
        GetPlayerAttribute();

    }

    private void GameInput_OnOpenInventoryAction(object sender, EventArgs e)
    {

       OnOpenInventory?.Invoke(this, EventArgs.Empty);
        
    }

    private void Update()
    {
        
        if (attackCooldown <= (1/attackSpeed))
        {
            attackCooldown += Time.deltaTime;
        }
        
    }


    private void GameInput_OnAttackAction(object sender, EventArgs e)
    {
       
        if (attackCooldown > (1 / attackSpeed))
        {
            if (comboDurantion < 0)
            {
                comboDurantion = 1f;
                attackIndex = 0;
            }
            else
            {
                if (attackIndex == 2)
                {
                    attackIndex = 0;
                }
                else
                {
                    attackIndex++;
                }

            }
            attackCooldown = 0f;
            
            
        }
        else
        {
            
        }
    }


    

    public override void ReduceHp(float dmg)
    {
        currentHp -= dmg;
        OnHpChange?.Invoke(this, new IHasHpBar.OnHpChangeEventArgs
        {
            HpNormalized = currentHp / HpMax
        });
        OnGetHit += D_Player_OnGetHit;
        Debug.Log("minus hp");
    }

    private void D_Player_OnGetHit(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
    public void OnCustomEvent()
    {
        OnGetHit?.Invoke(this, EventArgs.Empty);
        
    }

    public override void Heal(float amount)
    {
        if (currentHp <100 && currentHp+amount <=HpMax)
        {

        currentHp += amount;
       
        }
        else { currentHp += (HpMax - currentHp); }
        OnHpChange?.Invoke(this, new IHasHpBar.OnHpChangeEventArgs
        {
            HpNormalized = currentHp / HpMax
        });
    }

    public override void DealDamage(IReceiveDamage receiveDmg, float dmg)
    {
        receiveDmg.ReduceHp(dmg);

    }
    

    public override void GetPlayerAttribute()
    {

        
        speed = _playerAttribute.Speed;
        HpMax = _playerAttribute.Hp;
        currentHp = _playerAttribute.Hp;
        Dmg = _playerAttribute.Dmg;
        attackSpeed = _playerAttribute.AttackSpeed;
        Debug.Log(HpMax);
    }
    public override void CollectCoin(int amount)
    {
        coin += amount;
    }

    public override PlayerCharacterSO GetPlayerCharacterSO()
    {
        return _playerAttribute.playerCharacterSO;
    }
   
    
}
