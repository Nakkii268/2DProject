using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerDataSO m_PlayerDataSO;
    private int selectedOption = 0;

    public void UpdateCharacter(int selectOption)
    {
        PlayerCharacterSO character = m_PlayerDataSO.GetCharacter(selectOption);
        Save();
    }

   
    private void Save()
    {
        PlayerPrefs.SetInt("SelectedOption", selectedOption);
    }
}
