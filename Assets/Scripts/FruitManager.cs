using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FruitManager : MonoBehaviour
{
    public Text levelcleared;
    private void Update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if (levelcleared == null)
        { }
        
        if (transform.childCount==0)
        {
            Debug.Log("No quedan frutas, victoria");
            levelcleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
