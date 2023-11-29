using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCabanon : MonoBehaviour
{
    private LevelManager _levelManager;

    private void Start()
    {
        _levelManager = LevelManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        _levelManager.LoadScene("Level02");
    }
}
