using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DamageObject : MonoBehaviour
{
    public Transform player, respawnPoint;
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
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            collision.transform.GetComponent<SavePosition>().CargarDatos();
            audioSource.Play();

        }
    }
}
