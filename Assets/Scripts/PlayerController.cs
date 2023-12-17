using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private LevelManager levelManager;

    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI keyYes;
    [SerializeField] private TextMeshProUGUI keyNo;


    private void Update()
    {
        gameController.UpdateTimer(Time.deltaTime);
        UpdateUITimer();
        UpdateUIPoints();
        UpdateUIKey();
    }

    private void UpdateUITimer()
    {
        if (gameController.CurrentTime <= 0)
        {
            levelManager.LoadScene("LastScene");
        }

        string minutes = Mathf.Floor(gameController.CurrentTime / 60).ToString("00");
        string seconds = Mathf.Floor(gameController.CurrentTime % 60).ToString("00");

        timerText.text = $"{minutes}:{seconds}";
    }

    private void UpdateUIPoints()
    {
        string points = (gameController.Points).ToString();

        pointsText.text = $"{points}";
    }

    private void UpdateUIKey()
    {
        if (gameController.Key == true)
        {
            keyYes.gameObject.SetActive(true);
            keyNo.gameObject.SetActive(false);
        }
        else
        {
            keyYes.gameObject.SetActive(false);
            keyNo.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Interactible"))
        {
            gameController.InspectObject();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Key"))
        {
            gameController.FindKey();
            Destroy(other.gameObject);
        }
    }
}
