using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEglise : MonoBehaviour
{
    private LevelManager _levelManager;
    [SerializeField] private GameController gameController;

    private void Start()
    {
        _levelManager = LevelManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameController.Key == true)
        {
            _levelManager.LoadScene("Level03");
        }
    }
}
