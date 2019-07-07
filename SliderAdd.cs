using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderAdd : MonoBehaviour
{
    public static Slider sliderValue;


    void Start()
    {
        sliderValue = GetComponent<Slider>();
        sliderValue.value = 0f;
    }

    void Update()
    {  }
}