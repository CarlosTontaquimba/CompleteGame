using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnForQuizPanel : MonoBehaviour
{
    //Este escript retorna al Game canvas despues de presionar responder con un boton del Quizcanvaz
    public void Return()
    {
        if (a == true)
        {
            a = false;
            canvas.enabled = false;
        }
    }
}
