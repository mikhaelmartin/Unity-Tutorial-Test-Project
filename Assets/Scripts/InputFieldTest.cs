using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldTest : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;

    private void Start() {
        inputField.text = "Username";
    }

    public void OnValueChanged(string value)
    {
        Debug.Log("value changed :" + value);
    }
    public void OnSelect(string value)
    {
        Debug.Log("selected :" +value);
    }
    public void OnEndEdit(string value)
    {
        Debug.Log("end edit :" +value);
    }
    public void OnDeselect(string value)
    {
        Debug.Log("deselected :" +value);
    }
}
