using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour, IReceiveDamage, IDealDamage,IHasHpBar
{
    private static Player instance;
    public static Player Instance {
        get { return instance; }
    }


    [SerializeField] internal  PlayerMovement _playerMovement;
    [SerializeField] internal PlayerAttribute _playerAttribute;
    [SerializeField] internal PlayerInteract _playerInteract;
    [SerializeField] internal PlayerCollider _playerCollider;
    [SerializeField] internal Attack _playerAttack;
    [SerializeField] internal PlayerInventory _playerInventory;
    //[SerializeField] internal GameInput _gameInput;

    public BoxCollider2D boxCollider;
    public abstract event EventHandler  OnInteractSomething;
    public abstract event EventHandler OnOpenShop;
    public abstract event EventHandler OnOpenBase;
    public abstract event EventHandler OnOpenInventory;
    
    public abstract event EventHandler OnGetHit;
    public abstract event EventHandler<IHasHpBar.OnHpChangeEventArgs> OnHpChange;

    //[SerializeField] private Weapon weapon;
    [SerializeField] public int attackIndex;
    [SerializeField] public float comboDurantion = 1f;
    [SerializeField] public float attackCooldown;

    //stat
    [SerializeField] public float Dmg;
    [SerializeField] public float speed;
    [SerializeField] public float attackSpeed;
    [SerializeField] public float currentHp;
    [SerializeField] public float HpMax;
    [SerializeField] public float coin;
    protected virtual void Awake()
    {
        instance = this; 
    }




    public abstract void DealDamage(IReceiveDamage receiveDmg, float dmg);


    public abstract void ReduceHp(float dmg);
    public abstract void Heal(float dmg);
    public abstract void GetPlayerAttribute();
    public abstract void CollectCoin(int amount);
    public abstract PlayerCharacterSO GetPlayerCharacterSO();
}

