using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpgrade : MonoBehaviour
{
    public static PlayerUpgrade instance { get; private set; }
    private int HpUpgradeLv=0;
    private int DmgUpgradeLv=0;
    private int SpeedUpgradeLv = 0;
    private int ASUpgradeLv=0;
    private float HpPerLv=20f;
    private float DmgPerLv = 2f;
    private float SpeedPerLv=.1f;
    private float ASPerLv=.2f;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    public void HpUpgrade()
    {
        Player.Instance._playerAttribute.Hp += HpPerLv;
        HpUpgradeLv++;
        Player.Instance.GetPlayerAttribute();
    }
    public void DamageUpgrade()
    {
        Player.Instance._playerAttribute.Dmg += DmgPerLv;
        DmgUpgradeLv++;
        Player.Instance.GetPlayerAttribute();
    }
    public void SpeedUpgrade()
    {
        Player.Instance._playerAttribute.Speed += SpeedPerLv;
        SpeedUpgradeLv++;
        Player.Instance.GetPlayerAttribute();
    }
    public void AttackSpeedUpgrade()
    {
        Player.Instance._playerAttribute.AttackSpeed += ASPerLv;
        ASUpgradeLv++;
        Player.Instance.GetPlayerAttribute();
    }

    public void ResetUpgrade()
    {
        HpUpgradeLv = 0;
        DmgUpgradeLv = 0;
        SpeedUpgradeLv = 0;
        ASUpgradeLv = 0;
        Player.Instance._playerAttribute.Hp -= HpUpgradeLv * HpPerLv;
        Player.Instance._playerAttribute.Dmg -= DmgUpgradeLv * DmgPerLv;
        Player.Instance._playerAttribute.Speed -= SpeedUpgradeLv * SpeedPerLv;
        Player.Instance._playerAttribute.AttackSpeed -= ASUpgradeLv * ASPerLv;

    }

    public float HpUpgradeAmount()
    {
        return HpPerLv * HpUpgradeLv;
    }
    public float DmgUpgradeAmount()
    {
        return DmgPerLv * DmgUpgradeLv;
    }
    public float SpeedUpgradeAmount()
    {
        return SpeedPerLv * SpeedUpgradeLv;
    }
    public float AttackSpeedUpgradeAmount()
    {
        return ASPerLv * ASUpgradeLv;
    }
}
