using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager1 : MonoBehaviour
{

    public Text puntuacionText;

    public float puntuacionValue1;

    public Text maxPuntuacionText;

    public float maxPuntuacion;

    public GameObject mensaje1;
    public GameObject mensaje2;
    


    private void Start()
    {

        maxPuntuacion = PlayerPrefs.GetFloat("MaxPuntuacion");
        maxPuntuacionText.text = maxPuntuacion.ToString("0.00");

    }

    void Update()
    {
        puntuacionValue1 += Time.deltaTime;

        puntuacionText.text = puntuacionValue1.ToString("0.00");

        if (maxPuntuacion < puntuacionValue1)
        {
            PlayerPrefs.SetFloat("MaxPuntuacion", puntuacionValue1);

            maxPuntuacionText.text = puntuacionValue1.ToString("0.00");
        }


        if (puntuacionValue1 >= 2)
        {
            mensaje1.SetActive(true);
        }

        if (puntuacionValue1 >= 50)
        {
            mensaje1.SetActive(false);
            mensaje2.SetActive(true);
        }

        if (puntuacionValue1 >= 100)
        {
            
            

        }
        if (puntuacionValue1 >= 1500)
        {
            SceneManager.LoadScene("Level 3");
        }

    }


    public void AddPuntuation1(float puntuationObjectValue)//Para añadir puntuacion para cada fruta
    {
        puntuacionValue1 += puntuationObjectValue;//Se suma la puntuacion al coger una fruta

    }


}