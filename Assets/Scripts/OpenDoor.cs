using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    //Hacemos referencia al texto presione pantalla para ingresar
    public Text text;
    public string levelName;
    public bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //En caso de que toquemos la puerta
        if (collision.gameObject.CompareTag("Player")) //Si el que colisiona el el Player
        {
            text.gameObject.SetActive(true);//Enotnces activamos el texto
            inDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //En caso de que dejemos de tocar la puerta
        if (collision.gameObject.CompareTag("Player")) //Si el que colisiona el el Player
        {
            text.gameObject.SetActive(false);//Enotnces activamos el texto
            inDoor = false;
        }
    }
    private void Update()
    {
        if (inDoor  && Input.GetMouseButtonDown(0)) //Si hacemos clic en la pantalla
        {
            SceneManager.LoadScene(levelName);
        }   
    }
}
