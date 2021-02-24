using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    //ESTE SCRIPT REINICIA EL JUEGO EN UN PUNTO DONDE SE ALMACENO 
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    //
  
    private void Start()
    {
        
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
        PlayerPrefs.SetFloat("checkPointPositionX",x);//Guarda la informacion de la x
        PlayerPrefs.SetFloat("checkPointPositionY", y);//Guarda la informacion de la y
    }
    //Es el metodo que se llama desde los enemigos para activar la animacion de muerto
    public void PlayerDamaged()
    {
        //Este codigo activa la animacion del PlayerDie
        UpdateState("PlayerDie");
        //Una vez muerto reseteamos el nivel 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reiniciamos  al escena actual 
    }
    //Metodo para activar animaciones del animator
    public void UpdateState(string state = null)
    {
        if (state != null)
        {
            animator.Play(state);
        }
    }
}
