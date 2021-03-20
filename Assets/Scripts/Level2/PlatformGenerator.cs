using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformGenerator : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("X = " + rigidbody2D.velocity.x);
        if (rigidbody2D.velocity.x <= 3 )
        {
            Debug.Log("Estoy en movimineto");
        }
        else
        {

            Debug.Log("Estoy en parado");
        }
        //Debug.Log(rigidbody2D.velocity.x);
    }
}
