using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //Llamamops el metod de la clase PlayerRespawn
            collision.GetComponent<PlayerRespawn>().ReachedCheckPoint(transform.position.x,transform.position.y);
            Debug.Log("Golpeó chek point");
        }
    }
}
