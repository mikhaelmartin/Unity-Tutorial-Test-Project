using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // void Start()
    // {
    //     PlayerPrefs.DeleteAll();

    //     Debug.Log(PlayerPrefs.HasKey("player_health"));

    //     PlayerPrefs.SetFloat("player_health",100);
    //     PlayerPrefs.SetInt("player_cash",1000);
    //     PlayerPrefs.SetString("player_name","Player X");

    //     Debug.Log(PlayerPrefs.HasKey("player_health"));

    //     PlayerPrefs.DeleteKey("player_health");

    //     Debug.Log( "player_health: " + PlayerPrefs.HasKey("player_health"));
    //     Debug.Log( "player_cash: " + PlayerPrefs.HasKey("player_cash"));
    //     Debug.Log( "player_name: " + PlayerPrefs.HasKey("player_name"));

    //     Debug.Log(PlayerPrefs.GetFloat("player_health",10));
    //     Debug.Log(PlayerPrefs.GetInt("player_cash",0));
    //     Debug.Log(PlayerPrefs.GetString("player_name","player"));
    //     PlayerPrefs.Save(); 
    // }

    public static void SaveData(Player player)
    {
        PlayerPrefs.SetFloat("pos_x",player.transform.position.x);
        PlayerPrefs.SetFloat("pos_y",player.transform.position.y);
        PlayerPrefs.SetFloat("pos_z",player.transform.position.z);

        PlayerPrefs.SetString("player_name",player.gameObject.name);
        PlayerPrefs.SetFloat("player_health",player.Data.Health);
        PlayerPrefs.SetInt("player_score",player.Data.Score);

        PlayerPrefs.Save();        
    }

    public static PlayerData LoadData()
    {
        var tempData = new PlayerData();

        var x = PlayerPrefs.GetFloat("pos_x");
        var y = PlayerPrefs.GetFloat("pos_y");
        var z = PlayerPrefs.GetFloat("pos_z");

        tempData.Position = new Vector3(x,y,z);
        
        tempData.Name = PlayerPrefs.GetString("player_name");
        tempData.Health = PlayerPrefs.GetFloat("player_health");;
        tempData.Score = PlayerPrefs.GetInt("player_score");;
        return tempData;
    }

}
