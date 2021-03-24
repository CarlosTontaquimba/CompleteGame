using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteMove : MonoBehaviour
{
    // ESTE SCRIPT HACE QUE EL COHETE SE MUEVA DE DERECHA A IZQUIERDA
    public float velocity = 2f;
    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.left * velocity; // Hace que un objeto se mueca hacia la izquierda
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
