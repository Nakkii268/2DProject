using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] private BaseManagerUI m_baseManagerUI;
    [SerializeField] private PlayerDataSO m_PlayerDataSO;
    private int m_selectedOption;



    private void Start()
    {
        Player.Instance._playerCollider.OnOpenBase += Player_OnOpenBase;
        if (!PlayerPrefs.HasKey("SelectedOPtion"))
        {
            m_selectedOption = 0;
        }
        UpdateCharacter(m_selectedOption);
    }
    private void Load(int selectedOption)
    {
        PlayerPrefs.GetInt("SelectedOption", selectedOption);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("SelectedOption", m_selectedOption);
    }
    public void NextOption()
    {
        m_selectedOption++;
        if( m_selectedOption >= m_PlayerDataSO.CharacterCount)
        {
            m_selectedOption = 0;
        }
        UpdateCharacter(m_selectedOption);
       // Save();
        
        Debug.Log(PlayerPrefs.GetInt("SelectedOption", m_selectedOption));
    }
    public void PreOption()
    {
        if (m_selectedOption ==0)
        {
            m_selectedOption =m_PlayerDataSO.CharacterCount -1;
        }
        m_selectedOption--;
        UpdateCharacter(m_selectedOption);
       // Save();
    }

    public void UpdateCharacter(int selectedOption)
    {
        PlayerCharacterSO characterSO = m_PlayerDataSO.GetCharacter(selectedOption);
        m_baseManagerUI.LoadVisual(characterSO);
    }
    private void Player_OnOpenBase(object sender, System.EventArgs e)
    {
        m_baseManagerUI.Show();
        UpdateCharacter(m_selectedOption);
        Save();

    }
    public void CloseBaseUI()
    {
        m_baseManagerUI.Hide();
        
    }
    public void OnSelecteChar()
    {
        Save(); 
        m_baseManagerUI.ReloadOnSelect();
    }
}
