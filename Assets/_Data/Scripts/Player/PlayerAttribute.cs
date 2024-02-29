using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttribute : MonoBehaviour
{
    public PlayerCharacterSO playerCharacterSO;
  //  [SerializeField] Player _player;
    public float Dmg;
    public float Speed;
    public float Hp;
    public float AttackSpeed;

    private void Awake()
    {
        GetPlayerCharacterSOAttribute();
    }
    private void GetPlayerCharacterSOAttribute()
    {
       
        Dmg = playerCharacterSO.Dmg; 
        Speed = playerCharacterSO.Speed;   
        Hp = playerCharacterSO.Hp;
        AttackSpeed = playerCharacterSO.AttackSpeed;
    }





}
