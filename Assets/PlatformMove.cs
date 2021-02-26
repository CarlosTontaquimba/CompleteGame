using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //El momento que colisionamos 
            collision.collider.transform.SetParent(transform);
            CheckGround.isGrounded = true;
            Debug.Log(CheckGround.isGrounded);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null);
            CheckGround.isGrounded = false;
            Debug.Log(CheckGround.isGrounded);
        }
    }
}
