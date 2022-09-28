using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData Data;
    [SerializeField] TMP_Text statsText;

    private void OnEnable() {
        Data = DataManager.LoadData();
        transform.position = Data.Position;
        gameObject.name = Data.Name;
    }
    
    private void OnDisable() {
        DataManager.SaveData(this);
    }

    float timer = 0;
    private void Update() {
        Data.Health+= Time.deltaTime;
        timer+= Time.deltaTime;

        if(timer>=1)
        {
            Data.Score+= 1;
            timer=0;
        }

        statsText.text = $"Health: {Data.Health}{"\n"}Score: {Data.Score}";
    }

    public void ResetScore() {
        Data.Score=0;
    }

}
