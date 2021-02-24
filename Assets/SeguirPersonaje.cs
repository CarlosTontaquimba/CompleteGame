using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform objetivo;
    public float separacion = 0.50f;
    Vector3 desface;
    // Start is called before the first frame update
    void Start()
    {
        desface = transform.position - objetivo.position;  
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(objetivo.position.x + separacion, transform.position.y, transform.position.z);
    }
}
