using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour
{
   public abstract void MeleeAttack(int indx);
   public abstract void RangeAttack(int indx);
    
}
