using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateRamps : MonoBehaviour
{
    public GameObject ramps;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ramps.SetActive(false);
        }
    }
}
