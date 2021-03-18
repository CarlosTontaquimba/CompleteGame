using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //MANEGA LAS ORACIONES DE CADA UNO DE LOS PERSONAJES

    public Dialogue dialogue;
    Queue<string> sentences; //Es un listado de objetos en este caso de oraciones
    public GameObject dialoguePanel; //Aqui esta el panel que contiene el texto
    public Text displayText; //Texto que representa cada uno d elas oraciones
    string activeSentence; //COntiene el valor de la oracion actual
    public float typingSpeen; //Rapidez con la que la oracion se irá creando

    private void Start()
    {
        sentences = new Queue<string>();
    }
    void StartDialogue()
    {
        sentences.Clear();
        foreach (string sentence in dialogue.sentenceList)
        {
            sentences.Enqueue(sentence); // LO que hace el Enqueue es toma la oracion y la añade al queue para ser presentado 
        }
        DisplayNextSentence();
    }
    void DisplayNextSentence()
    {
        if (sentences.Count <= 0)
        {
            displayText.text = activeSentence;
            return;
        }
        activeSentence = sentences.Dequeue();//Dequeue saca la oracion de el listado y la pasa a la variable active sentences
        displayText.text = activeSentence;
        //Debug.Log(activeSentence);

        StopAllCoroutines();
        StartCoroutine(TypeTheSentence(activeSentence));
    }

    IEnumerator TypeTheSentence(string sentence)
    {
        displayText.text = ""; //Elimino cuaquier texto
        foreach (char letter  in sentence.ToCharArray())
        {
            displayText.text += letter;
            //myAudio.PlayoneShot(speakAudio); //Sonido de letra
            yield return new WaitForSeconds(typingSpeen); //Para que aparezcan lentamente 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            StartDialogue();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.H) && displayText.text == activeSentence)
            {
                DisplayNextSentence();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopAllCoroutines();
    }
}
