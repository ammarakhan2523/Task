using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
   
    public Text sliderText;
    //private EnemySpawner enemySpawner;
    public void OnSliderValueChanged(float value)
    {
        EnemySpawner.instance.spawnInterval = value;
        sliderText.text = "Delay Value: " + value.ToString();
    }
}
