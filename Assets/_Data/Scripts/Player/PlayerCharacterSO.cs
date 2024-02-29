using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class PlayerCharacterSO : ScriptableObject
{
    public Sprite CharacterAvata;
    public GameObject playerVisualPrefab;
    public Sprite characterSprite;
    public string characterName;
    public float Dmg ;
    public float Speed ;
    public float Hp ;
    public float AttackSpeed ;
}
