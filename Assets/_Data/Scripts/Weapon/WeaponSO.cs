using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class WeaponSO : ScriptableObject
{
    public Transform weaponPrefab;
    public Sprite weaponSprite;
    public string weaponName;
    public float weaponDmg;
    public float weaponSpeed;
}
