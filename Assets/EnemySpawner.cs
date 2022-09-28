using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    public void SpawnRandom()
    {
        Vector3 randomPos = new Vector3(
            x: Random.Range(-5,5),
            y: 0.5f,
            z: Random.Range(-5,5)
        );
        GameObject newEnemy = Instantiate(enemyPrefab,this.transform,true);        
        Enemy enemyScript = newEnemy.GetComponent<Enemy>();
        enemyScript.power += Random.Range(-2f,2f);
    }
}
