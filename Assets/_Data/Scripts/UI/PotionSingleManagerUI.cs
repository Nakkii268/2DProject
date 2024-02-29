using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PotionSingleManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI amountText;
    [SerializeField] Image sprite;
    [SerializeField] PotionSO m_potionSO;
    private InventoryUI m_inventoryUI;

    private void Start()
    {
        m_inventoryUI = InventoryUI.Instance;
    }

    public void SetPotionSO(PotionSO potionSO)
    {
        amountText.text = "1";
        sprite.sprite = potionSO.sprite;
        m_potionSO = potionSO;
    }

    public void UsingPotion()
    {
        Player.Instance.Heal(m_potionSO.HealAmount);
        Player.Instance._playerInventory.RemoveItem(m_potionSO);
        m_inventoryUI.LoadInventory();
    }
}
