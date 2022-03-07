using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UiManager : MonoBehaviour
{
   public AudioSource clip;
   public GameObject optionsPanel;

    public void OptionsPanel() {
        
        Time.timeScale = 0; //Parar el tiempo
        optionsPanel.SetActive(true);//Se activa el panel
        
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        
        foreach (AudioSource a in audios)
        {
           
            a.Pause();

        }

    }

    public void Return() {

        Time.timeScale = 1; //Reanudar el tiempo
        optionsPanel.SetActive(false); //Desactivar el panel
        AudioSource[] audios = FindObjectsOfType<AudioSource>();//Definir un vector de audios

        foreach (AudioSource a in audios)//Recorre todos los vectores
        {
            a.Play();

        }

    }

    

    public void goMenu() {
        
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu"); //Ir al menu
    
    }

    public void quitGame() { 
    Application.Quit();//Salir del juego
    }

    public void PlaySoundButtom() {

        clip.Play();    
    }

}
