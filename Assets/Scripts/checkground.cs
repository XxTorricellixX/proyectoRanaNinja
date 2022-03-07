using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkground : MonoBehaviour
{
    public static bool isGroundred;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Ground"))
        {
            isGroundred = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGroundred = false;

        }
        
    }
}
