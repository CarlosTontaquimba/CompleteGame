﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popUP : MonoBehaviour
{
    public GameObject[] panel;

    public bool a = false,detectCollision = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Flag")
        {
            SceneManager.LoadScene("MenuScreen");
        }
        if (collision.transform.tag == "Flag1")
        {
            SceneManager.LoadScene("MenuScreen1");
        }
        if (collision.transform.tag == "DetectCollisionFlags")
        {
            detectCollision = false;
            Debug.Log("¡Cambio detect collisoin ?? "+detectCollision);
        }
        if (collision.transform.tag == "InfoCheck")
        {
            panel[0].GetComponent<ActiveObjectTransition>().Activar();
            panel[1].GetComponent<ActiveObjectTransition>().Activar();
        }
        if (collision.transform.tag == "InfoCheck1")
        {
            panel[2].GetComponent<ActiveObjectTransition>().Activar();
            panel[3].GetComponent<ActiveObjectTransition>().Activar();
        }
        if (collision.transform.tag == "Infocheck2")
        {
            panel[4].GetComponent<ActiveObjectTransition>().Activar();
            panel[5].GetComponent<ActiveObjectTransition>().Activar();
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panel[0].GetComponent<ActiveObjectTransition>().Desactivar();
        panel[1].GetComponent<ActiveObjectTransition>().Desactivar();
        panel[2].GetComponent<ActiveObjectTransition>().Desactivar();
        panel[3].GetComponent<ActiveObjectTransition>().Desactivar();
        panel[4].GetComponent<ActiveObjectTransition>().Desactivar();
        panel[5].GetComponent<ActiveObjectTransition>().Desactivar();
    }
}
