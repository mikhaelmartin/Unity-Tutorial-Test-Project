using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleStatus : MonoBehaviour
{
    [SerializeField] Toggle toggle;

    [SerializeField] bool toggleStatus;

    private void Update() {
        toggleStatus = toggle.isOn;
    }
}
