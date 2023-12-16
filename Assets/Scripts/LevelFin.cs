using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFin : MonoBehaviour
{
    private LevelManager _levelManager;

    private void Start()
    {
        _levelManager = LevelManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        _levelManager.LoadScene("LastScene");
    }
}
