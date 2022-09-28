using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    [SerializeField] Slider slider;
    private void Start() {
        slider.value = 0.25f;
    }

    private void Update() {
        Debug.Log(slider.value);
    }

    public void ValueChanged(float value)
    {
        Debug.Log(value);
    }
}
