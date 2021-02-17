using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondManager : MonoBehaviour
{
    //Este metodo detecta si el diamante es recogido 
    public void AllDiamondsCollected()
    {
        if(transform.childCount == 1)
        {
            Debug.Log("Diamantes recolectados, nivel superado");
        }
    }
}
