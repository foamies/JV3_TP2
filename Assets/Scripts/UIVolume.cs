using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIVolume : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private Slider slider;
    [SerializeField] private AudioMixer audioMixer;

    void Start()
    {
        slider.value = gameController.Volume;

        slider.onValueChanged.AddListener(UpdateSliderValue);
    }

    void UpdateSliderValue(float value)
    {
        gameController.Volume = value;

        audioMixer.SetFloat("MUSVolume", Mathf.Log10(gameController.Volume) * 20);
    }
}
