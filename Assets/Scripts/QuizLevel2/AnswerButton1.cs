using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton1 : MonoBehaviour {

    public Text answertext1;

    private AnswerData1 answerData1;

    private GameController1 gameController1;


	// Use this for initialization
	void Start ()
    {

        gameController1 = FindObjectOfType<GameController1>();
    }

    public void Setup(AnswerData1 data)
    {
        answerData1 = data;
        answertext1.text = answerData1.answerText;
    }
	
	public void HandleClick()
    {
        gameController1.AnswerButtonClicked(answerData1.isCorrect);
    }
}
