using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) //Si ha coleccionado el player 
        {
            //Debug.Log("Player damaged");
            //Destruimos el objeto
            //Destroy(collision.gameObject);
            //LLamamos el metodo de la clase PlayerRaspawn
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
