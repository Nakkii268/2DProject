using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private PotionSO[] potionList;
    [SerializeField] private Sprite openedChestSprite;
    private int OpenedTime;
    private Player player;

    private void Start()
    {
        player = Player.Instance;
    }

    public void InteractHandler()
    {
        ChestLooting(); 
       gameObject.GetComponentInChildren<SpriteRenderer>().sprite = openedChestSprite;
        Invoke("DestroySelf", 5f);
        OpenedTime++;
    }

    private void ChestLooting()
    {
        if(OpenedTime == 0)
        {

        player.coin += 10;
        player._playerInventory.AddItem(potionList[Random.Range(0,3)]);
        }
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
