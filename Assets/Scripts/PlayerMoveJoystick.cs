using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip jumpClip;
    private float horizontalMove = 0f;
    public Joystick joystick;
    public float runSpeedHorizontal = 2;
    public float runSpeed = 1.25f;
    public float jumpSpeed = 4.5f;
    Rigidbody2D rb2d;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("Run",true);
            
        }
        else
        {
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump",true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }
    }
    private void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
    }
    public void Jump()
    {
        //SALTAR
        if (CheckGround.isGrounded) //Cuando este en el suelo
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed); // Entonces salte
            audioSource.clip = jumpClip;
            audioSource.Play();

        }
        //FIN SALTO
    }
}
