using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDealDamage 
{
    void DealDamage(IReceiveDamage receiveDmg, float dmg);
}
