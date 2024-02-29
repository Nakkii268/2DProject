using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Potion : MonoBehaviour, IInteractable
{
    [SerializeField] private PotionSO potionSO;
    [SerializeField] private SpriteRenderer sprite;



    private void Start()
    {
        sprite.sprite = potionSO.sprite;
    }


    public PotionSO GetPotionSO()
    {
        return potionSO;
    }

    public void InteractHandler()
    {
        Debug.Log("Interacted");
        DestroyObject();

    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    public float GetHealAmount()
    {
        return potionSO.HealAmount;
    }
    
}
