using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI pointsText;

    void Update()
    {
        gameController.UpdateTimer(Time.deltaTime);
        UpdateUITimer();
        UpdateUIPoints();
    }

    void UpdateUITimer()
    {
        string minutes = Mathf.Floor(gameController.CurrentTime / 60).ToString("00");
        string seconds = Mathf.Floor(gameController.CurrentTime % 60).ToString("00");

        timerText.text = $"{minutes}:{seconds}";
    }

    void UpdateUIPoints()
    {
        string points = (gameController.Points).ToString();

        pointsText.text = $"{points}";
    }
}
