using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour
{
   [SerializeField] private PlayerDataSO playerDataSO;
    void Awake()
    {
      
        SpawnCharacter(); 
    }
    public void SpawnCharacter()
    {
        int index;
        if (!PlayerPrefs.HasKey("SelectedOption"))
        {
            index = 0;
        }
        index = PlayerPrefs.GetInt("SelectedOption");

        Transform player = playerDataSO.GetCharacter(index).playerVisualPrefab.transform;
        Instantiate(player,gameObject.transform);
        //SavingData.Instance.LoadPlayerData();
       // Player.Instance.GetPlayerData();
        
        
    }
   public void ChildDestroy()
    {
        foreach(Transform child in transform)
        {
           child.gameObject.SetActive(false);
        }
    }
   
}
