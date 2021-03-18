using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjectTransition : MonoBehaviour
{
    public Animator animator;
    public void Activar()
    {
        animator.SetBool("Active", true);
    }
    public void Desactivar()
    {
        animator.SetBool("Active", false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
