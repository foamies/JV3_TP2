using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCimetiere : MonoBehaviour
{
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = LevelManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        levelManager.LoadScene("Level01");
    }
}
