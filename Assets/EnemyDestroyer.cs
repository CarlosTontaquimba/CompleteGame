using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    //ESTE SCRIPT DESTRUYE TOPDOS LOS OBJETOS QUE COLISIONAN CONTRA EL  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Enemy") || collision.transform.CompareTag("CreateEnemyActivator"))
        {
            Destroy(collision.gameObject); 
        }
    }
}
