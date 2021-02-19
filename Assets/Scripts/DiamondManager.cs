using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Para cambiar de escena 
using UnityEngine.SceneManagement;

public class DiamondManager : MonoBehaviour
{
    public Text totalDiamonds; //Para saber todas los diamantes que hay en el nivel
    public Text diamondsCollected; //Para saber los diamantes que emos cogido
    private int totalDiamondsInLevel; 
    public GameObject transition;
    private void Start()
    {
        totalDiamondsInLevel = transform.childCount;
    }
    private void Update()
    {
        AllDiamondsCollected();
        //Las diamantes que hay en todo el nivel y poder ver por pantalla
        totalDiamonds.text = totalDiamondsInLevel.ToString();
        //Para contar los diamantes que vamos recolectando
        diamondsCollected.text = transform.childCount.ToString();
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
