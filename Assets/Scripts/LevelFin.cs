using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFin : MonoBehaviour
{
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = LevelManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        levelManager.LoadScene("LastScene");
    }
}
