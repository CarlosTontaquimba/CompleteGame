using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStopGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Debug.Log("Game paused " + Time.timeScale);
            AudioSource[] audios = FindObjectsOfType<AudioSource>();//Devuelve todos loc omponentes audio source que encuentre 
            foreach (AudioSource a in audios) // Para cada coponente audio source a
            {
                a.Pause(); // Ejecute el método pausa
            }
        }
        else
        {
            Time.timeScale = 1;
            Debug.Log("Game runing " + Time.timeScale);
            AudioSource[] audios = FindObjectsOfType<AudioSource>();//Devuelve todos loc omponentes audio source que encuentre 
            foreach (AudioSource a in audios) // Para cada coponente audio source a
            {
                a.Play(); // Ejecute el método play
            }
        }
    }
}
