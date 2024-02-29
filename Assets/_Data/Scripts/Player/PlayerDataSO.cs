using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class PlayerDataSO : ScriptableObject
{
    public PlayerCharacterSO[] playerSOs;

    public int CharacterCount
    {
        get
        {
            return playerSOs.Length;
        }
    }

    public PlayerCharacterSO GetCharacter(int index)
    {
        return playerSOs[index];
    }
}
