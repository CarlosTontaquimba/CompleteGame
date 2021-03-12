using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUP : MonoBehaviour
{
    public Canvas canvas;
    public bool a = false;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PopUp();
        }
    }
    public void PopUp()
    {
        if (a == false)
        {
            a = true;
            canvas.enabled = true;
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
