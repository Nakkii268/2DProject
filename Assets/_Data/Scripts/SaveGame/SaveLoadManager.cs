using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private string dataPath;
    private SaveLoadManager instance;
    public SaveLoadManager Instance {  get { return instance; } }

    private void Awake()
    {
        instance= this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        dataPath = Path.Combine(Application.persistentDataPath, "playerData.json");
    }

    public void SavePlayerData(PlayerSaveData playerData)
    {
        string jsonData = JsonUtility.ToJson(playerData);
        File.WriteAllText(dataPath, jsonData);
    }

    public PlayerSaveData LoadPlayerData()
    {
        if (File.Exists(dataPath))
        {
            string jsonData = File.ReadAllText(dataPath);
            return JsonUtility.FromJson<PlayerSaveData>(jsonData);
        }
        else
        {
            Debug.LogError("Save file not found in " + dataPath);
            return null;
        }
    }
}
