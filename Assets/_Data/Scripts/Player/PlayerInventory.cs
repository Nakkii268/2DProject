using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
  //  public static PlayerInventory instance {  get; private set; }
   [SerializeField] public List<PotionSO> playerPotion;

   // private void Awake()
  //  {
  //      instance = this; 
 //   }
    

    private void Start()
    {
        playerPotion = new List<PotionSO>();
    }

    public void AddItem(PotionSO potion)
    {
      
         playerPotion.Add(potion); 
    }
    public void RemoveItem(PotionSO item)
    {
       
        playerPotion.Remove(item);
       
    }

    public List<PotionSO> GetPlayerItem()
    {
        return playerPotion;
    }
}
