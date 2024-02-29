using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManagerment : MonoBehaviour
{
    public static GameManagerment Instance { get; private set; }
    private bool isGamePause;
    public event EventHandler OnGamePause;
    public event EventHandler OnGameResume;


    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        GameInput.Instance.OnGamePauseAction += GameInput_OnGamePauseAction;
    }

    private void GameInput_OnGamePauseAction(object sender, System.EventArgs e)
    {
        PasueGame();
    }

    public void PasueGame()
    {
        if (isGamePause)
        {
            Time.timeScale = 1f;
            isGamePause = false;
            OnGameResume?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            Time.timeScale = 0;
            isGamePause = true;
            OnGamePause?.Invoke(this, EventArgs.Empty);
        }
    }
}
