using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPuntuation1 : MonoBehaviour
{
    public float puntuacionValue = 10; //Puntuacion si ha colisionado 

    private void OnTriggerEnter2D(Collider2D collision) //Reconocer si ha colisionado con el jugador
    {
        if (collision.CompareTag("Player"))//Si ha colosionado con el jugador (Tag Player)
        {
            FindObjectOfType<MinigameManager1>().AddPuntuation1(puntuacionValue);//Añade a la puntuacion global
        }
    }
}
