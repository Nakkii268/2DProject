using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class GamePauseUI : MonoBehaviour
{
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button menuButton;

    private void Awake()
    {
        resumeButton.onClick.AddListener(() =>
        {
            GameManagerment.Instance.PasueGame();
        });
        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
        menuButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MenuScene);
            Time.timeScale = 1f;
        });
    }

    private void Start()
    {
        GameManagerment.Instance.OnGamePause += GameManagerment_OnGamePause;
        GameManagerment.Instance.OnGameResume += GameManagerment_OnGameResume;
        Hide();
    }

    private void GameManagerment_OnGameResume(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void GameManagerment_OnGamePause(object sender, System.EventArgs e)
    {
        Show();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }
}
