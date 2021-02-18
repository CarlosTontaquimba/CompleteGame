using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para cambiar de escena 
using UnityEngine.SceneManagement;

public class DiamondManager : MonoBehaviour
{
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
            //Cuando ya no haya frutas
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Se debe añadir las escenas en File-> Build Settings
        }
    }
}
