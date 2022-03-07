using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Respawn : MonoBehaviour
{

    public AudioSource clip;
    public GameObject[] hearts;
    private int life;
    
    private float checkPointPositionX, checkPointPositionY;

    public Animator animator;

    void Start()
    {
        life = hearts.Length; 

        if(PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"),PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    private void Checklife()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("Hit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            clip.Play();
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("Hit");
            clip.Play();
        }
        else if (life < 3) {
            Destroy(hearts[2].gameObject);
            animator.Play("Hit");
            clip.Play();
        }
  
    }


    public void ReachedCheckPoint(float x,float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositionX", y);
    }

    public void PlayerDamaged()
    {
        life--;
        Checklife();
    }
}
