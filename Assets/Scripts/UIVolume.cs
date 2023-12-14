using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIVolume : MonoBehaviour
{
    public GameController gameController;
    public Slider slider;

    void Start()
    {
        slider.value = gameController.Volume;

        slider.onValueChanged.AddListener(UpdateSliderValue);
    }

    void UpdateSliderValue(float value)
    {
        gameController.Volume = value;
    }

}
