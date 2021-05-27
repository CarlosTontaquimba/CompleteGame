using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour {
    public void StartGame()
    {

        if (SceneCounter.counterScene == 0)
        {
            SceneManager.LoadScene("Game");
            SceneCounter.counterScene++;
        }
        else if (SceneCounter.counterScene == 1)
        {
            SceneManager.LoadScene("Game1L1");
            SceneCounter.counterScene++;
        }
        else if (SceneCounter.counterScene == 2)
        {
            SceneManager.LoadScene("Game2L1");
            SceneCounter.counterScene = 0;
        }
    }
    public void StartGame1()
    {

        if (SceneCounter.counterScene == 0)
        {
            SceneManager.LoadScene("Game1");
            SceneCounter.counterScene++;
        }
        else if (SceneCounter.counterScene == 1)
        {
            SceneManager.LoadScene("Game1L2");
            SceneCounter.counterScene++;
        }
        else if (SceneCounter.counterScene == 2)
        {
            SceneManager.LoadScene("Game2L2");
            SceneCounter.counterScene = 0;
        }
    }
    private void Update()
    {
       Debug.Log(SceneCounter.counterScene);
    }
}
