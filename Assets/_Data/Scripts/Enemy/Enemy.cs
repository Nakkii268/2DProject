using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IReceiveDamage,IDealDamage,IHasHpBar
{
    public abstract event EventHandler<IHasHpBar.OnHpChangeEventArgs> OnHpChange;
    public abstract bool IsAlive();
    public abstract void StateUpdate();
    public abstract void VisualUpdate();
    public abstract void GetStat();
    public abstract void DestroySelf();
    public abstract void ReduceHp(float dmg);
    public abstract void DealDamage(IReceiveDamage receiveDmg, float dmg);

    public abstract void PlayAnimationAndDead();
}
