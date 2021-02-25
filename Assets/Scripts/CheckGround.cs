using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    //
  
    // Para detectar si esta tocando el suelo
    public static bool isGrounded; // Con el estatic puedo usar esta variable dentro de otro script
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Check ground = " + isGrounded);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("Check ground = " + isGrounded);
        }
    }
}
