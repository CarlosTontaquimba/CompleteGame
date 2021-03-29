using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float generatorTimer = 150f; //Cada cuanto se genera un enemigo

    private void Start()
    {
        InvokeRepeating("CreateCohete", 0f, generatorTimer);
    }
    void CreateCohete()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
