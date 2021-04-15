using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosePanelWithButton : MonoBehaviour
{
    public Canvas canvas;


    public bool a = false, detectCollision = false;

    public void CloseCanvas1()
    {
        SceneManager.LoadScene("Level1");
        canvas.enabled = false;
    }
    public void CloseCanvas2()
    {
        SceneManager.LoadScene("Level2");
        canvas.enabled = false;
    }


}
