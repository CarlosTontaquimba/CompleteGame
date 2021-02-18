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
    //***
    //Sprite renderer 
    public SpriteRenderer spriteRenderer;
    //******
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //Hacemos referecnia al rigidbody del personaje 
        rb2d = GetComponent<Rigidbody2D>();
        //Giramos nuestro player 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //MOVIMIENTO 
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            //El Vector2 pide como parametros el eje x e y
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y); //Corre a la derecha
            //El player gira a la derecha
            spriteRenderer.flipX = false;
            //Activamos la animacion caminar cuando se pulse una tecla izq, derech
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y); //Corre a la izquierda con run speed en negativo
            //El player gira a la derecha
            spriteRenderer.flipX = true;
            //Activamos la animacion caminar cuando se pulse una tecla izq, derech
            animator.SetBool("Run", true);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("Run", false);
        }
        //FIN MOVIMIENTO
        //SALTAR
        if (Input.GetKeyDown("up") && CheckGround.isGrounded) // Si se presiona las teclas y esta en el suelo --> salte
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
        //FIN SALTO
        if (CheckGround.isGrounded == false) //Cuando no esta en el suelo
        {
           // Debug.Log("Asi esta el check ground: " + CheckGround.isGrounded);
            //Esta saltando
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        
        if (CheckGround.isGrounded == true)//En el momento que esté en el suelo 
        {
            animator.SetBool("Jump", false); //Jump sera falso
        }
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
