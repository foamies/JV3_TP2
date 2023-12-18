using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameController", menuName = "ScriptableObjects/GameController", order = 1)]
public class GameController : ScriptableObject
{
    [SerializeField] private float startTime = 300f;
    [SerializeField] private float currentTime;

    [SerializeField] private int points;

    [SerializeField] private float volume;

    [SerializeField] private bool key;

    public float CurrentTime => currentTime;
    public int Points => points;
    public float Volume
    {
        get { return volume; }
        set { volume = Mathf.Clamp01(value); }
    }
    public bool Key => key;

    public void Initialize()
    {
        currentTime = startTime;
        points = 0;
        key = false;
    }

    public void UpdateTimer(float deltaTime)
    {
        currentTime -= deltaTime;
        if (currentTime < 0f)
        {
            currentTime = 0f;
            Debug.Log("Le temps est écoulé!");
        }
    }

    public void InspectObject()
    {
        points = points + 250;
    }

    public void FindKey()
    {
        key = true;
        points = points + 500;
    }
}
