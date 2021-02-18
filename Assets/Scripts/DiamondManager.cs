using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para cambiar de escena 
using UnityEngine.SceneManagement;

public class DiamondManager : MonoBehaviour
{
    public GameObject transition;
    private void Update()
    {
        AllDiamondsCollected();
    }
    //Este metodo detecta si el diamante es recogido 
    public void AllDiamondsCollected()
    {
        if(transform.childCount == 0)
        {
            Debug.Log("Diamantes recolectados, nivel superado");
            transition.SetActive(true);//Activamos la transicion haciendo referencia al game Object
            //Cuando ya no haya frutas cambiamops de escena
            Invoke("ChangeScene", 1); // Cambia de escena en 1 segundo
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Se debe añadir las escenas en File-> Build Settings
    }
}
