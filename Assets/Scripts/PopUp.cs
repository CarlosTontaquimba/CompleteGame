using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public GameObject player;
    public bool a = false;
    private void Update()
    {
        popUp();
    }
    public void popUp()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (a == false)
            {
                a = true;
                canvas.enabled = true;
                Debug.Log("Button pressed");
            }
            else if (a == true)
            {
                a = false;
                canvas.enabled = false;
                player.SetActive(true);
                Debug.Log("Button pressed");
            }
        }
    }
}
