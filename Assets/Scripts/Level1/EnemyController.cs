using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnemyController : MonoBehaviour
{
    public AudioClip dieClip;
    //SOnido de morir
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //OnTriggerEnter2D detecta cuando algo entra en contacor con el boxcollider2d o con cualquier otro collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //Debug.Log("Player Damaged");
            //Destroy(collision.gameObject);
            audioSource.clip = dieClip;
            audioSource.Play();
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
        else if (collision.transform.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
            Debug.Log("Enemigo detruido");
        }
    }
}
