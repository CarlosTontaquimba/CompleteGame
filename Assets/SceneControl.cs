﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu()
    {
        //Activamos el tiempo
        Time.timeScale = 1;
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Menu");
    }
}
