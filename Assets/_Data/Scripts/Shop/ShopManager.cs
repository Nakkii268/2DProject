using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] ShopUI shopUI;
    void Start()
    {
        Player.Instance._playerCollider.OnOpenShop += Player_OnOpenShop;
    }

    private void Player_OnOpenShop(object sender, System.EventArgs e)
    {
        shopUI.VisualUpdate();
        Debug.Log("OpenShop"); 
        shopUI.Show();
    }
    
   
}
