using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button newGame;
    [SerializeField] private Button quitGame;

    [SerializeField] private GameController gameController;

    private LevelManager levelManager;

    void Start()
    {
        levelManager = LevelManager.instance;

        newGame.onClick.AddListener(StartNewGame);
        quitGame.onClick.AddListener(QuitGame);
    }

    private void StartNewGame()
    {
        levelManager.LoadNewGame();
    }

    private void QuitGame()
    {
        levelManager.QuitGame();
    }
}
