using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public GameObject startPoint, endPoint;
    public float enemySpeed;//Velocidad de movimiento
    public bool isGoingRigth; //Si el jugador se esta moviendohacia la derecha o izquierda

    // Start is called before the first frame update
    void Start()
    {
        if (!isGoingRigth) // Si se mueve hacia la derecha
        {
            transform.position = startPoint.transform.position;
        }
        else // Si se mueve a la izquirda
        {
            transform.position = endPoint.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGoingRigth)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, enemySpeed * Time.deltaTime);
            if (transform.position == endPoint.transform.position)
            {
                isGoingRigth = true;
            }
        }
        if (isGoingRigth)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.transform.position, enemySpeed * Time.deltaTime);
            if (transform.position == startPoint.transform.position)
            {
                isGoingRigth = false;
            }
        }
    }
}
