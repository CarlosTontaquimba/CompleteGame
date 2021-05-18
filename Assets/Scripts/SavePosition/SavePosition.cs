using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePosition : MonoBehaviour
{
    private float PosX;
    private float PosY;
    private Vector2 Posicion;
    public void GuardarDatos()
    {
        PlayerPrefs.SetFloat("PosicionX", transform.position.x);
        PlayerPrefs.SetFloat("PosicionY", transform.position.y);
        Debug.Log("Datos guardados");
    }
    public void CargarDatos()
    {
        PosX = PlayerPrefs.GetFloat("PosicionX");
        PosY = PlayerPrefs.GetFloat("PosicionY");
        Posicion.x = PosX;
        Posicion.y = PosY;
        transform.position = Posicion;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag=="PosSave")
        {
            GuardarDatos();
        }
    }
}
