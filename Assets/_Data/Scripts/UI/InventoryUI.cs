using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance { get; private set; }
   // [SerializeField] private PlayerInventory inventory;
    [SerializeField] private Transform potionTemplate;
    [SerializeField] private Transform container;
    public bool isOpen;
    private void Awake()
    {if (Instance == null || Instance == this)
        {

        Instance = this;
        }
        else { //Destroy(Instance.gameObject);
               }
        //DontDestroyOnLoad(this.gameObject);
        Show();
    }
    private void Start()
    {
        Player.Instance._playerInteract.OnOpenInventory += Player_OnOpenInventory;
    }

    private void Player_OnOpenInventory(object sender, System.EventArgs e)
    {
        if (!isOpen)
        {
            Show();
            LoadInventory();
        }
        else
        {
            Hide();
        }
    }

    public void LoadInventory()
    {
        
         
        foreach (Transform child in Instance.container)
        {
            if (child == potionTemplate) continue;
            Destroy(child.gameObject);
        }
       
        var items= Player.Instance._playerInventory.GetPlayerItem();



        foreach (var item in items)
        {
            
            Transform potionTransform = Instantiate(potionTemplate, container);
            potionTransform.gameObject.SetActive(true);
            potionTransform.GetComponent<PotionSingleManagerUI>().SetPotionSO(item);
        }
    }
    

    public void Show()
    {
        isOpen = true;
        Instance.gameObject.SetActive(true);
        
    }
    public void Hide()
    {
        isOpen = false;
        Instance.gameObject.SetActive(false);
    }

}
