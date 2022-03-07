using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public AudioSource clip;
    public GameObject panelhistoria;

    public void Gogame() {
        SceneManager.LoadScene("Level 1");// Cargar primer nivel
    }

    public void goMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quitgame()
    {
        Application.Quit(); 
    }

    public void historyGame()
    {
        panelhistoria.SetActive(true);
    }
    public void PlaySoundButtom()
    {

        clip.Play();
    }
}
