using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{


    public Text questionDisplayText;
    public Text scoreDisplayText;
    public SimpleObjectPool1 answerButtonObjectPool1;
    public Transform answerButtonParent;
    public GameObject questionDisplay;
    public GameObject roundEndDisplay;

    private DataController1 dataController1;
    private RoundData1 currentRoundData1;
    private QuestionData1[] questionPool1;

    private bool isRoundActive;
    private float timeRemaining;
    private int questionIndex;
    private int playerScore;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        dataController1 = FindObjectOfType<DataController1>();
        currentRoundData1 = dataController1.GetCurrentRoundData();
        questionPool1 = currentRoundData1.questions;
        timeRemaining = currentRoundData1.TimeLimitInSeconds;

        playerScore = 0;
        questionIndex = 0;

        ShowQuestion();
        isRoundActive = true;

    }

    private void ShowQuestion()
    {
        RemoveAnswerButtons();
        QuestionData1 questionData1 = questionPool1[questionIndex];
        questionDisplayText.text = questionData1.QuestionText;

        for (int i = 0; i < questionData1.answers.Length; i++)
        {
            GameObject answerButtonGameObject = answerButtonObjectPool1.GetObject();
            answerButtonGameObjects.Add(answerButtonGameObject);
            answerButtonGameObject.transform.SetParent(answerButtonParent);

            AnswerButton1 answerButton1 = answerButtonGameObject.GetComponent<AnswerButton1>();
            answerButton1.Setup(questionData1.answers[i]);
        }
    }

    private void RemoveAnswerButtons()
    {
        while (answerButtonGameObjects.Count > 0)
        {
            answerButtonObjectPool1.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    public void AnswerButtonClicked(bool isCorrect)
    {
        if (isCorrect)
        {
            playerScore += currentRoundData1.PointsAddedForCorrectAnswer;
            scoreDisplayText.text = "Score: " + playerScore.ToString();
        }

        if (questionPool1.Length > questionIndex + 1)
        {
            questionIndex++;
            ShowQuestion();
        }
        else
        {
            EndRound();
        }

    }

    public void EndRound()
    {
        isRoundActive = false;

        questionDisplay.SetActive(false);
        roundEndDisplay.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }


    // Update is called once per frame
    void Update()
    {
        if (isRoundActive)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0f)
            {
                EndRound();
            }

        }
    }
}