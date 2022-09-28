using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    [SerializeField] Button button;

    

    private void Start()
    {
        button.onClick.AddListener(
            delegate ()
            {
                Attack();
            });

        button.onClick.AddListener(
            delegate ()
            {
                Print("ini adalah message");
            });
    }

    private void OnDestroy() {
        button.onClick.RemoveAllListeners();
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void Print(string message)
    {
        Debug.Log(message);
    }
}
