﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    //ESTE SCRIPT REINICIA EL JUEGO EN UN PUNTO DONDE SE ALMACENO 
    //VIDAS
    public GameObject[] hearts;
    private int life;
    public GameObject GameOver;
    //***
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    //Vidas
    //VIDASSLIDERpublic Slider vidasSlider;
    //public float danioEnemy;
    //*
  
    private void Start()
    {
        life = hearts.Length;
        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            //Enviamos el personaje a esa posision
            transform.position = new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY"));
        }
    }
    /*private void Update()
    {
        if(life == 5)
        {
            Debug.Log("Tienes vidas completas");
        }
        else if (true)
        {
            Debug.Log("Tienes" + life + "vidas");
            Debug.Log("Array de vidas "+hearts.Length);
        }
        
    }*/
    //Sirve para reinciar el juego donde quedò, por que guarda ifnrmacion del juego
    public void ReachedCheckPoint(float x, float y) //Metodo para detectar si se pasa por el checkpoint
    {
        //Guarda la posicion del check point
        PlayerPrefs.SetFloat("checkPointPositionX", x);//Guarda la informacion de la x
        PlayerPrefs.SetFloat("checkPointPositionY", -0.026f);//Guarda la informacion de la y
    }
    //Es el metodo que se llama desde los enemigos para activar la animacion de muerto
    public void PlayerDamaged()
    {
        life--;
        CheckLife();
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
    //Chequeamos las vidas
    void CheckLife()
    {
        if (life < 1) // Estamos muertos 
        {
            //Reiniciamos nivel
            
            Destroy(hearts[0].gameObject);
            // SceneManager.LoadScene("GameOver"); //Reiniciamos  al escena actual
            GameOver.SetActive(true);

        }
        else if (life < 2)
        {
            //Destruimos los dos corazones de la derecha
            Destroy(hearts[1].gameObject);
            //UpdateState("PlayerDie");
        }
        else if (life < 3)
        {
            //Destruimos el primer corazon de la derecha
            Destroy(hearts[2].gameObject);
            //UpdateState("PlayerDie");
        }
        else if (life < 4)
        {
            //Destruimos el primer corazon de la derecha
            Destroy(hearts[3].gameObject);
            //UpdateState("PlayerDie");
        }
        else if (life < 5)
        {
            //Destruimos el primer corazon de la derecha
            Destroy(hearts[4].gameObject);
            //UpdateState("PlayerDie");
        }
    }
    public void UpdateState(string state = null)
    {
        if (state != null)
        {
            animator.Play(state);
        }
    }

}
