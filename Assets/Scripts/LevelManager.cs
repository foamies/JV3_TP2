using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject _loaderCanvas;
    //[SerializeField] private Image _progressBar;

    public static LevelManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void LoadNewGame()
    {
        LoadScene("Level01");
    }

    public void LoadMainMenu()
    {
        LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log($"Quitter le jeu!");

        // Sauvegarde

        Application.Quit();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public async void LoadAsyncScene(string SceneName)
    {
        var scene = SceneManager.LoadSceneAsync(SceneName);

        scene.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

        do
        {
            await Task.Delay(100);

            //_progressBar.fillAmount = scene.progress;

        } while (scene.progress < 0.9f);

        scene.allowSceneActivation = true;

        _loaderCanvas.SetActive(false);
    }
}
