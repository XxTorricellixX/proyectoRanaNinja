using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour
{

    public Text puntuacionText;

    public float puntuacionValue;

    public Text maxPuntuacionText;
    
    public float maxPuntuacion;

    public GameObject mensaje1;
    public GameObject mensaje2;
    public GameObject mensaje3;


    private void Start() {
       
        maxPuntuacion = PlayerPrefs.GetFloat("MaxPuntuacion");
        maxPuntuacionText.text = maxPuntuacion.ToString("0.00");
        
    }

    void Update()
    {
        puntuacionValue+=Time.deltaTime;

        puntuacionText.text = puntuacionValue.ToString("0.00");

        if (maxPuntuacion < puntuacionValue)
        {
            PlayerPrefs.SetFloat("MaxPuntuacion", puntuacionValue);
            
            maxPuntuacionText.text = puntuacionValue.ToString("0.00");
        }
        if (puntuacionValue >= 2)
        {
            mensaje1.SetActive(true);
        }

        if (puntuacionValue >=50)
        {
            mensaje1.SetActive(false); 
            mensaje2.SetActive(true);
        }

        if (puntuacionValue >= 100)
        {
            mensaje2.SetActive(false);
            mensaje3.SetActive(true);
            
        }

        if (puntuacionValue >= 1000)
        {
            SceneManager.LoadScene("Level 2");
        }

    }


    public void AddPuntuation(float puntuationObjectValue)//Para añadir puntuacion para cada fruta
    {
      puntuacionValue += puntuationObjectValue;//Se suma la puntuacion al coger una fruta

    }


}



