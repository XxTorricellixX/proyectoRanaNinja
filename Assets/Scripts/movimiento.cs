using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    public float runSpeed=2;

    public float jumpSpeed=3;

    public float doubleJumpSpeed = 1.0f;

    private bool canDoubleJump;

    Rigidbody2D rb2D;//Fisicas

    public bool betterJump = false;

    public float fallMultiplier = 0.5f;

    public float lowJumpMutiplier = 1f;

    public SpriteRenderer spriteRenderer;

    public Animator animator;
 
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();//Obtener las fisicas
    }

    private void Update()
    {
        if (Input.GetKey("space") )
        {
            if(checkground.isGroundred)
            {
                canDoubleJump = true;
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            }
            else
            {
                if(Input.GetKeyDown("space"))
                {
                    if(canDoubleJump)
                    {
                        animator.SetBool("DoubleJump", true);
                        rb2D.velocity = new Vector2(rb2D.velocity.x, doubleJumpSpeed);
                        canDoubleJump = false;
                    }
                }
            }
        }

        if (checkground.isGroundred == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (checkground.isGroundred == true)
        {
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
        }
    }


    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed,rb2D.velocity.y);//Direccion donde ir
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left")) {

            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }

        

        if (betterJump)
        {
            if(rb2D.velocity.y<0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }

            if(rb2D.velocity.y>0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMutiplier) * Time.deltaTime;
            }
        }

    }
}