using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    //Rango de tiempo para generar enemigo
    //public float  minTime = 1.5f,maxTime = 4f;
    //***

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreateEnemy();
    }
    void CreateEnemy()
    { 
        Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)], transform.position, Quaternion.identity);
    }
    
}
