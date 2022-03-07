using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPuntuation : MonoBehaviour
{
    public float puntuacionValue = 10; //Puntuacion si ha colisionado 

    private void OnTriggerEnter2D(Collider2D collision) //Reconocer si ha colisionado con el jugador
    {
        if (collision.CompareTag("Player"))//Si ha colosionado con el jugador (Tag Player)
        {
            FindObjectOfType<MinigameManager>().AddPuntuation(puntuacionValue);//A�ade a la puntuacion global
        }
    }
}
