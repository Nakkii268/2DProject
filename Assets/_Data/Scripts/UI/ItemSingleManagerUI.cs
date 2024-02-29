using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSingleManagerUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI itemName;
    [SerializeField]private TextMeshProUGUI itemPrice;
    [SerializeField]private Image itemSprite;
    public event EventHandler OnBuyItem;
    private PotionSO potionSO;

    public void SetPotionSOShop(PotionSO _potionSO)
    { 
        itemName.text = _potionSO.name;
        itemPrice.text = _potionSO.Price.ToString();
        itemSprite.sprite = _potionSO.sprite;
        potionSO = _potionSO;
    }

    public void BuyItem()
    {
        if(Player.Instance.coin >=potionSO.Price)
        {
        Player.Instance._playerInventory.AddItem(potionSO);
        Player.Instance.coin -= potionSO.Price;

        OnBuyItem?.Invoke(this, EventArgs.Empty);
            Debug.Log("BuyAHop");
        }
    }

}
