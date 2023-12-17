using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILastScene : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    [SerializeField] private Button btnRetour;
    [SerializeField] private TextMeshProUGUI pointage;

    private LevelManager levelManager;

    void Start()
    {
        levelManager = LevelManager.instance;

        pointage.text = (gameController.Points).ToString();

        btnRetour.onClick.AddListener(ReturnMainMenu);
    }

    private void ReturnMainMenu()
    {
        levelManager.LoadScene("MainMenu");
    }
}
