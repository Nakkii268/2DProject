using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField] private WeaponSO weaponSO;
   [SerializeField] private float weaponDamage;
    [SerializeField] private float weaponSpeed;

    private void Start()
    {
        weaponDamage = weaponSO.weaponDmg;
        weaponSpeed = weaponSO.weaponSpeed;
        GetComponentInChildren<SpriteRenderer>().sprite = weaponSO.weaponSprite;
      
    }

  

    public void SetWeaponSO()
    {
        weaponDamage = weaponSO.weaponDmg;
        weaponSpeed = weaponSO.weaponSpeed;
        GetComponentInChildren<SpriteRenderer>().sprite = weaponSO.weaponSprite;
    }
    public void ChangeWeaponSO(WeaponSO newWeaponSO)
    {
        weaponSO = newWeaponSO;
    }
}
