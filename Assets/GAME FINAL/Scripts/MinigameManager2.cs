using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigameManager2 : MonoBehaviour
{

    public Text puntuacionText;

    public float puntuacionValue2;

    public Text maxPuntuacionText;

    public float maxPuntuacion;

    public GameObject mensaje1;
    public GameObject mensaje2;
    public GameObject mensaje3;


    private void Start()
    {

        maxPuntuacion = PlayerPrefs.GetFloat("MaxPuntuacion");
        maxPuntuacionText.text = maxPuntuacion.ToString("0.00");

    }

    void Update()
    {
        puntuacionValue2 += Time.deltaTime;

        puntuacionText.text = puntuacionValue2.ToString("0.00");

        if (maxPuntuacion < puntuacionValue2)
        {
            PlayerPrefs.SetFloat("MaxPuntuacion", puntuacionValue2);

            maxPuntuacionText.text = puntuacionValue2.ToString("0.00");
        }

        if (puntuacionValue2 >= 2)
        {
            mensaje1.SetActive(true);
        }

        if (puntuacionValue2 >= 50)
        {
            mensaje1.SetActive(false);
            mensaje2.SetActive(true);
        }

        if (puntuacionValue2 >= 100)
        {
            mensaje2.SetActive(false);
            mensaje3.SetActive(true);

        }
        if (puntuacionValue2 >= 1600)
        {
            SceneManager.LoadScene("Final");
        }


    }


    public void AddPuntuation2(float puntuationObjectValue)//Para añadir puntuacion para cada fruta
    {
        puntuacionValue2 += puntuationObjectValue;//Se suma la puntuacion al coger una fruta

    }


}