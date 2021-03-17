using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour {
    public Canvas canvas;
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

}
