using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUpgradeUI : MonoBehaviour
{
    [SerializeField] private Button upgradeHPButton;
    [SerializeField] private Button upgradeDmgButton;
    [SerializeField] private Button upgradeSpeedButton;
    [SerializeField] private Button upgradeASButton;
    private void Awake()
    {
        upgradeHPButton.onClick.AddListener(() =>
        PlayerUpgrade.instance.HpUpgrade()
        
        ); ;
        upgradeDmgButton.onClick.AddListener(() =>
        PlayerUpgrade.instance.DamageUpgrade()
        );
        upgradeSpeedButton.onClick.AddListener(() =>
        PlayerUpgrade.instance.SpeedUpgrade()
        );
        upgradeASButton.onClick.AddListener(() =>
        PlayerUpgrade.instance.AttackSpeedUpgrade()
        );
    }
}
