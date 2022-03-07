using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObject1 : MonoBehaviour
{
    public GameObject[] enemies;

    public float timeSpawn = 1;
    public float repeatRespawn = 3;

    public Transform xRangeLeft;
    public Transform xRangeRight;

    public Transform yRangeUp;
    public Transform yRangeDown;

    public GameObject[] fruits;
    public float timeSpawnFruits = 1;
    public float repatSpawnRateFruits = 3;

    public float difficultyTime = 0;

    private void Update()
    {
        difficultyTime += Time.deltaTime;//Cuanto tiempo ha pasado 

        if (difficultyTime > 10 && difficultyTime < 20) //Despues de determinado tiempo
        {
            repeatRespawn = 2;//Mas objetos cayendo
            repatSpawnRateFruits = 3.5f;//Menos frutas cayendo
        }

        if (difficultyTime > 10 && difficultyTime < 20)
        {
            repeatRespawn = 1;
            repatSpawnRateFruits = 4f;
        }

        if (difficultyTime > 30 && difficultyTime < 50)
        {

            repeatRespawn = 0.75f;
        }

        if (difficultyTime > 50)
        {
            repeatRespawn = 0.50f;
        }

        

    }






    void Start()
    {

        StartCoroutine("EnemyDifficulty");
        StartCoroutine("FruitDifficulty");//Llamando a la corrutina

    }


    public void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject enemie = Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPosition, gameObject.transform.rotation);

    }

    public void SpawnFruits()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject fruit = Instantiate(fruits[Random.Range(0, fruits.Length)], spawnPosition, gameObject.transform.rotation);

    }

    IEnumerator EnemyDifficulty()
    { //Corrutinas
        yield return new WaitForSeconds(repeatRespawn);// Esperar el spawn de los enemigos
        SpawnEnemies();
        StartCoroutine("EnemyDifficulty");//Bucle de rutina
    }
    IEnumerator FruitDifficulty()
    { //Corrutinas
        yield return new WaitForSeconds(repatSpawnRateFruits);// Esperar el spawn de las frutas
        SpawnFruits();
        StartCoroutine("FruitDifficulty");//Bucle de rutina
    }
}
