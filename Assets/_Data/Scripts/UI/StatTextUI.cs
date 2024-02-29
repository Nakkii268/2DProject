using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatTextUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HpText;
    [SerializeField] private TextMeshProUGUI DmgText;
    [SerializeField] private TextMeshProUGUI SpeedText;
    [SerializeField] private TextMeshProUGUI ASpeedText;
    private Player player;
    private PlayerUpgrade playerUpgrade;
    private void Start()
    {
        player = Player.Instance;
        playerUpgrade = FindAnyObjectByType<PlayerUpgrade>().GetComponent<PlayerUpgrade>();
        
    }
    public void LoadStatText()
    {
        HpText.text = "Health: " + player._playerAttribute.Hp.ToString() + "(+" + playerUpgrade.HpUpgradeAmount().ToString() + ")";
        DmgText.text = "Damage: " + player._playerAttribute.Dmg.ToString() + "(+" + playerUpgrade.DmgUpgradeAmount().ToString() + ")";
        SpeedText.text = "Speed: " + player._playerAttribute.Speed.ToString() + "(+" + playerUpgrade.SpeedUpgradeAmount().ToString() + ")";
        ASpeedText.text = "A.Speed: " + player._playerAttribute.AttackSpeed.ToString() + "(+" + playerUpgrade.AttackSpeedUpgradeAmount().ToString() + ")";
        Debug.Log("Loaded");
    }
}
