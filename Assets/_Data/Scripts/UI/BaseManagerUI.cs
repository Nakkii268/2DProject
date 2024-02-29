using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseManagerUI : MonoBehaviour
{
    [SerializeField] private Image playerSprite;
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private StatTextUI statTextUI;


    private void Start()
    {
        
        Hide();
    }

    

    public void LoadVisual(PlayerCharacterSO   playerCharacterSO)
    {
        playerSprite.sprite = playerCharacterSO.characterSprite;
        playerName.text = playerCharacterSO.characterName;
    }

    public void Show()
    {
        gameObject.SetActive(true);
        statTextUI.LoadStatText();
        Debug.Log("CanLoad");


    }
    public void Hide()
    {
        gameObject.SetActive(false);
       
    }
    public void ReloadOnSelect()
    {
        Loader.ReloadScene();
    }
 }
