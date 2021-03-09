using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Es correcto");
            quizManager.Correct();
        }
        else
        {
            Debug.Log("Es incorrecto");
            quizManager.Correct();
        }
    }
}
