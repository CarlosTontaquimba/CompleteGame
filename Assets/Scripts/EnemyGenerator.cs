using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //public GameObject[] enemyPrefab;
    public GameObject enemyPrefab;
    //Rango de tiempo para generar enemigo
    public float gereatorTimer = 1.75f;
    //***

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("CreateEnemy",0f, gereatorTimer); //El 0f es el tiempo de retardo que tiene la primera vez que se ejecuta esta invocacion y despues cada 1.75 segundos
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("CreateEnemyActivator"))
        {
            Debug.Log("Generador golpeo a activador");
            InvokeRepeating("CreateEnemy", 0f, gereatorTimer); //El 0f es el tiempo de retardo que tiene la primera vez que se ejecuta esta invocacion y despues cada 1.75 segundos
        }
    }

}
