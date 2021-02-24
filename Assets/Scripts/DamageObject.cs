using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DamageObject : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) //Si ha coleccionado el player 
        {
            Debug.Log("Player damaged");
            //Destruimos el objeto
            //Destroy(collision.gameObject);
            //LLamamos el metodo de la clase PlayerRaspawn
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            audioSource.Play();

        }
    }
}
