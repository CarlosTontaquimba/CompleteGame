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
    public Text diamondsCollected1; //Para saber los diamantes que emos cogido en el panel game over
    private int totalDiamondsInLevel;
    public static int totalDiamondsCollected;
    //Esto es para el game over
    private int collectedDiamondsGamOvr = 0;
    private int initDiamonds = 52;
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
        totalDiamondsCollected = transform.childCount; // Se almacena el numero de puntos recogidos
        ShowCollectedDiamonds();
        /*if (transform.childCount == 30)
        {
            Debug.Log("Hola llegue a treinta");
        }*/
    }
    //Este metodo detecta si el diamante es recogido 
    public void AllDiamondsCollected()
    {
        if(transform.childCount == 0) // Si todos los diamantes son recolectados, haga algo 
        {
            Debug.Log("Diamantes recolectados, nivel superado");
            //Cuando ya no haya frutas cambiamops de escena
            Invoke("ChangeScene", 1); // Cambia de escena en 1 segundo
        }
    }
    public void ShowCollectedDiamonds()
    {
        totalDiamondsCollected = transform.childCount; // Son 52
        collectedDiamondsGamOvr = initDiamonds - totalDiamondsCollected;
        //Debug.Log("Mostrando diamnates recolectasdos = " + collectedDiamondsGamOvr);
        diamondsCollected1.text = collectedDiamondsGamOvr.ToString();
    }
}
