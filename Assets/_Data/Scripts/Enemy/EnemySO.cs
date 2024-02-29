using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class EnemySO : ScriptableObject
{
    public Transform prefab;
    public Sprite sprite;
    public string enemyName;
    public float Dmg;
    public float Speed;
    public float Hp;
    public float currentHp;
    public float attackRange;
    public float attackSpeed;
    public float activeRange;
    public bool dead;
    public int coinDrop;
    public bool isBoss;
 }
