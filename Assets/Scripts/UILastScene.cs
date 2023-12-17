using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILastScene : MonoBehaviour
{
    [SerializeField] private Button btnRetour;

    private LevelManager levelManager;

    void Start()
    {
        levelManager = LevelManager.instance;

        btnRetour.onClick.AddListener(ReturnMainMenu);
    }

    private void ReturnMainMenu()
    {
        levelManager.LoadScene("MainMenu");
    }
}
