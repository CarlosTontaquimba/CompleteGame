using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //Esto le da visibilidad a ls variables dentro del inspector
public class Dialogue
{
    //ESTA CLASE DETERMINA EL NOMBRE DEL PERSONAJE Y EL DICTADO QUE VA HA TENER 

    public string name; //Nombre del personaje
    [TextArea(3,10)]//Esto determina el valor minimo de lineas y el valor maximo de lineas  [TextArea] => Sin limite
    public string[] sentenceList;//Listado de oraciones
}
