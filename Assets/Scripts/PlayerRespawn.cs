using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    //ESTE SCRIPT REINICIA EL JUEGO EN UN PUNTO DONDE SE ALMACENO 
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    //Vidas
    public GameObject[] hearts;
    private int lifes;
    //*
  
    private void Start()
    {
        lifes = hearts.Length;
        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            //Enviamos el personaje a esa posision
            transform.position = new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY"));
        }
    }
    //Sirve para reinciar el juego donde quedò, por que guarda ifnrmacion del juego
    public void ReachedCheckPoint(float x, float y) //Metodo para detectar si se pasa por el checkpoint
    {
        //Guarda la posicion del check point
        PlayerPrefs.SetFloat("checkPointPositionX", 21.27f);//Guarda la informacion de la x
        PlayerPrefs.SetFloat("checkPointPositionY", -0.1f);//Guarda la informacion de la y
    }
    //Es el metodo que se llama desde los enemigos para activar la animacion de muerto
    public void PlayerDamaged()
    {
        /*
        //Este codigo activa la animacion del PlayerDie
        UpdateState("PlayerDie"); */
        CheckLifes();
        lifes--;
        //Una vez muerto reseteamos el nivel 
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reiniciamos  al escena actual 
    }
    //Metodo para activar animaciones del animator
    public void UpdateState(string state = null)
    {
        if (state != null)
        {
            animator.Play(state);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
    //Chequeamos las vidas
    public void CheckLifes()
    {
        Debug.Log("Las vidas que tienes son : " + lifes);
        if (lifes == 1)
        {
            //Destruimos el ultimo corazon que nos queda
            Destroy(hearts[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reiniciamos  al escena actual
        }
        else if (lifes == 2 )
        {
            //Destruimos el ultimo corazon que nos queda
            Destroy(hearts[1].gameObject);
            
        }
        else if (lifes == 3)
        {
            //Destruimos el ultimo corazon que nos queda
            Destroy(hearts[2].gameObject);
            
        }
    }
}
