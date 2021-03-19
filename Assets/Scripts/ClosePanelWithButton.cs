using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosePanelWithButton : MonoBehaviour
{
    public Canvas canvas;


    public bool a = false, detectCollision = false;

    public void CloseCanvas()
    {
        SceneManager.LoadScene("Level1");
        canvas.enabled = false;
    }


}
