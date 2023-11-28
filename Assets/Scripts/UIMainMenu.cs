using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _newGame;
    [SerializeField] Button _quitGame;

    private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.instance;

        _newGame.onClick.AddListener(StartNewGame);
        _quitGame.onClick.AddListener(QuitGame);
    }

    private void StartNewGame()
    {
        _levelManager.LoadNewGame();
    }

    private void QuitGame()
    {
        _levelManager.QuitGame();
    }
}
