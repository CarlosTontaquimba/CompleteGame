using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovee : MonoBehaviour
{
    //Para controlar fuerza de salto
    //public bool betterJump = false;
    //*************

    //Para controlar fuerza de salto alto
    //public float fallMultiplier = 0.5f;
    //*************
    //Para controlar fuerza de salto bajjo
   // public float lowJumpMultiplier = 1f;
    // Velocidad de correr
    public float runSpeed = 2f;
    //*******
    //Velocidad de salto
    public float jumpSpeed = 4.5f;
    //******************
    //Recuperamos el rigidbody
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        //Hacemos referecnia al rigidbody del personaje 
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //MOVIMIENTO 
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            //El Vector2 pide como parametros el eje x e y
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y); //Corre a la derecha
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y); //Corre a la izquierda con run speed en negativo
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        //FIN MOVIMIENTO
        //SALTAR
        if (Input.GetKeyDown("up") && CheckGround.isGrounded) // Si se presiona las teclas y esta en el suelo --> salte
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
        //FIN SALTO
        //COntrol salto 
      /*  if (betterJump)
        {
            if (rb2d.velocity.y < 0)
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime; // El up significa que en x=0, e Y = 1 
            }
            if (rb2d.velocity.y > 0 && !(Input.GetKeyDown("up")))
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime; // El up significa que en x=0, e Y = 1 
            }
        }*/
    }
}
