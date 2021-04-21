using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popUP : MonoBehaviour
{
    public Canvas canvas;
    public GameObject[] panel;

    public bool a = false,detectCollision = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Flag")
        {
            SceneManager.LoadScene("MenuScreen");
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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panel[0].GetComponent<ActiveObjectTransition>().Desactivar();
        panel[1].GetComponent<ActiveObjectTransition>().Desactivar();
    }
    public void PopUp()
    {
        if (a == false)
        {
            a = true;
            canvas.enabled = true;
            a = true;
        }
    }
    public void Return()
    {
        if (a == true)
        {
            a = false;
            canvas.enabled = false;
        }
    }


}
