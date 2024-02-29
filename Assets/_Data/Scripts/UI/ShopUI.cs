using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    [SerializeField] private ShopDataBaseSO SDBSO;
   [SerializeField] private List<PotionSO> potionlist;
    [SerializeField] private Transform container;
   [SerializeField] private Transform itemTemplate;
    [SerializeField] private TextMeshProUGUI playerCoin;
    [SerializeField] private ItemSingleManagerUI itemSingleManagerUI;
    private InventoryUI inventoryUI;
    private void Awake()
    {
        VisualUpdate();
        Hide();
    }
    private void Start()
    {
        inventoryUI= InventoryUI.Instance;
        potionlist = SDBSO.PotionSOs;
        itemSingleManagerUI.OnBuyItem += ItemSingleManagerUI_OnBuyItem;
    }

    private void ItemSingleManagerUI_OnBuyItem(object sender, System.EventArgs e)
    {
        SetPlayerCoin();
        inventoryUI.LoadInventory();
        Debug.Log("Buy");
    }

    public void VisualUpdate()
    {
        foreach(Transform child in container)
        {
            if (child == itemTemplate) continue;
            Destroy(child.gameObject);
        }
        foreach(var item in potionlist)
        {
            Transform potionTransform = Instantiate(itemTemplate, container);
            potionTransform.gameObject.SetActive(true);
            potionTransform.GetComponent<ItemSingleManagerUI>().SetPotionSOShop(item);
        }
        SetPlayerCoin();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        
    }
    public void SetPlayerCoin()
    {
        playerCoin.text = Player.Instance.coin.ToString();

    }
}
