using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QaA;
    public GameObject[] options;
    public int currentQuiestions;
    public Text questionText;
    private void Start()
    {
        GenerateQuestions();
    }
    public void Correct()
    {
        QaA.RemoveAt(currentQuiestions);
        GenerateQuestions();
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QaA[currentQuiestions].Answers[i];
            if (QaA[currentQuiestions].correctAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void GenerateQuestions()
    {
        currentQuiestions = Random.Range(0, QaA.Count);
        questionText.text = QaA[currentQuiestions].questions;
        SetAnswers();
    }
}
