using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
//ESTE SCRIPT GESTIONA TODOS LOS CONTROLES PARA EL MENU DE OPCIONES 
public class UIManager : MonoBehaviour
{
    public AudioSource clip;
    //Referencia al panel de mennu
    public GameObject optionsPanel;
    public void OptionsPanel()
    {
        //Paramos el tiempo en unity 
        Time.timeScale = 0;
        //Activamos el panel 
        optionsPanel.SetActive(true);

    }
    public void Return()
    {
        //Activamos el tiempo en unity
        Time.timeScale = 1;
        //Desactivamos el panel de options
        optionsPanel.SetActive(false);
    }
    public void AnotherOptions()
    {
        //Sound
        //Music
        //Grphics
    }
    //Poder ir al menu principal
    public void GoToMainMenu()
    {
        //Activamos el tiempo
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    //Salir del juego 
    public void QuitGame()
    {
        //Esto funcionarà unicmente cuando se saca el apk del juego
        Application.Quit();
    }
    public void Restart()
    {
        //Activamos el tiempo
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    //Metodod para iniciar sonido cuando aplasto en el icono de opciones
    public void PlaySound()
    {
        clip.Play();
    }
    public void GameOver()
    {
        //Paramos el tiempo en unity 
        Time.timeScale = 0;
        //Activamos el panel 
        optionsPanel.SetActive(true);

    }
}
