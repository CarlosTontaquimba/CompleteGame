using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    private void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            //Enviamos el personaje a esa posision
            transform.position = new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY"));
        }
    }
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
        //animator.Play("PlayerDie");
        //Una vez muerto reseteamos el nivel 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reiniciamos  al escena actual
    }
}
