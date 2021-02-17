using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) //Si ha coleccionado el player 
        {
            Debug.Log("Player damaged");
            //Cuandpo entremos en se tpo de cosas destruimos el player
            Destroy(collision.gameObject);
        }
    }
}
