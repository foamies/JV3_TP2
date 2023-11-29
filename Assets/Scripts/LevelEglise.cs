using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEglise : MonoBehaviour
{
    private LevelManager _levelManager;

    private void Start()
    {
        _levelManager = LevelManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        //_levelManager.LoadScene("Level03");
        _levelManager.LoadScene("Level04"); //Seulement pour tester l'avancement
    }
}
