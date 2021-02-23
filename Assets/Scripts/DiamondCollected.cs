using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class DiamondCollected : MonoBehaviour
{
    public AudioSource audioSource;
    //OnTriggerEnter2D detecta cuando algo entra en contacor con el boxcollider2d
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Desactivar Sprite Renderer
            GetComponent<SpriteRenderer>().enabled = false;
            //Destruimos objeto
            Destroy(gameObject, 0.5f);
            //Activamos sonido de points
            audioSource.Play();

        }   
    }
}
