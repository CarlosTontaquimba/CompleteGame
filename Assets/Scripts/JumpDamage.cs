using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpDamage : MonoBehaviour
{
    //ESTE ESCRIPT AYUDA PARA SABER SI SE SALTA ENCIMA DEL ENEMIGO SOMBRERO Y MATARLO
    //Para saber si estamos colisionando 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Hcer que el player rebote al matar al enemigo
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,200f));
            Destroy(transform.parent.gameObject); //Destruimos el objeto padre
            //Destroy(gameObject); //Destruimos unicamente el objeto hijo
        }
    }

}
