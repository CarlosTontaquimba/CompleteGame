using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Defino un vector de conponentes audio source 
        AudioSource[] audios = FindObjectsOfType<AudioSource>();//Devuelve todos loc omponentes audio source que encuentre 
        foreach (AudioSource a in audios) // Para cada coponente audio source a
        {
            a.Pause(); // Ejecute el método pausa
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
