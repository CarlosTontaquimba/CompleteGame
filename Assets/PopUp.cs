using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public GameObject player;
    public bool a = false;
    public void popUp()
    {
        if (a == false)
        {
            a = true;
            canvas.enabled = true;
        }
        else if (a == true)
        {
            a = false;
            canvas.enabled = false;
            player.SetActive(true);
        }
    }
}
