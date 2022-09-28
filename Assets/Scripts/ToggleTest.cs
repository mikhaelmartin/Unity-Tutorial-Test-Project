using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTest : MonoBehaviour
{
    public void Print(bool value)
    {
        if (value)
        {
            Debug.Log("YA");
        }
        else
        {
            Debug.Log ("TIDAK");            
        }
    }

    public void Print()
    {
        Debug.Log("print tanpa input");
    }
}
