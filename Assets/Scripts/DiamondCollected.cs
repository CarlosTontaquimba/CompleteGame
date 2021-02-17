using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollected : MonoBehaviour
{
    //OnTriggerEnter2D detecta cuando algo entra en contacor con el boxcollider2d
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Desactivar Sprite Renderer
            GetComponent<SpriteRenderer>().enabled = false;
            //Llamamo al metodo de la clase DiamondManager
            FindObjectOfType<DiamondManager>().AllDiamondsCollected();  
            //Destruimos objeto
            Destroy(gameObject, 0.05f);

        }   
    }
}
