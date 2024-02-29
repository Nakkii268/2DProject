using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    public event EventHandler OnOpenShop;
    public event EventHandler OnOpenBase;
    private InventoryUI inventoryUI;
    [SerializeField]private Player _player;
    void Start()
    {
       // _player = Player.Instance;
        boxCollider = GetComponent<BoxCollider2D>();
        inventoryUI = InventoryUI.Instance;

    }
    public void ColliderAnother()
    {
        RaycastHit2D hit;
        hit = Physics2D.BoxCast(transform.position, boxCollider.size * 2f, 0, new Vector2(0, 0), 0f, LayerMask.GetMask("Block"));
        if (hit.collider)
        {
            //Item item = 
            if (hit.collider.CompareTag("Shop"))
            {
                OnOpenShop?.Invoke(this, EventArgs.Empty);


            }
            if (hit.collider.CompareTag("Base"))
            {
                OnOpenBase?.Invoke(this, EventArgs.Empty);


            }
            
        }

    }
    public void ColliderInteractable()
    {
        RaycastHit2D hit;
        hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.size * 2f, 0, new Vector2(0, 0), 0f, LayerMask.GetMask("Interactable"));
        if (hit.collider)
        {
            // Portion item = 
            if (hit.collider.TryGetComponent<Potion>(out Potion potion))
            {
                potion.InteractHandler();
                // Heal(potion.GetHealAmount());
               _player._playerInventory.AddItem(potion.GetPotionSO());
                inventoryUI.LoadInventory();

            }
            if (hit.collider.TryGetComponent<Chest>(out Chest chest))
            {
                chest.InteractHandler();
                inventoryUI.LoadInventory();

            }
            if (hit.collider.TryGetComponent<StreetLight>(out StreetLight light))
            {
                light.InteractHandler();
               

            }

        }

    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
       if( collision.transform.GetChild(0).TryGetComponent(out InteractUI interactUI))
        {
            interactUI.Show();

        }

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.GetChild(0).TryGetComponent(out InteractUI interactUI))
        {
            interactUI.Hide();

        }
    }
}


