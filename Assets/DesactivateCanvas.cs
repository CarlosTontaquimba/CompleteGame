﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateCanvas : MonoBehaviour
{
    public GameObject canvas ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }
}
