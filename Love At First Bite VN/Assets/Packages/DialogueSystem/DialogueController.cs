using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Hierarchy;
using UnityEditor;
using UnityEngine;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class DialogueController : MonoBehaviour
{
   /* //[SerializeField] private TextMeshProUGUI playerNameText;
    [SerializeField] private TextMeshProUGUI SpeakText;
    [SerializeField] private float typeSpeed = 10;

    private Queue<string> sentences = new Queue<string> ();

    private bool conversationEnded;
    private bool isTyping;

    private string p;

    private Coroutine typeDialogueCoroutine;

    private const string HTML_ALPHA = "<color=#00000000>";
    private const float MAX_TYPE_TIME = 0.1f;


    public void ShowNextSentence(DialogueManager dialogueManager)
    {
        //if there is nothing in the queue
        if (sentences.Count == 0)
        {
            if (!conversationEnded)
            {
                //start a conversation
                StartConversation(dialogueManager);
            }

            else if (conversationEnded && !isTyping)
            {
                //end the conversation
                EndConversation();
                return;
            }
        }

        //if there is something in the queue
        if (!isTyping)
        {
            p = sentences.Dequeue();
            
            typeDialogueCoroutine = StartCoroutine(TypeDialogueManager(p));
        }

        //conversation IS being typed out
        else
        {
            FinishSentenceEarly();
        }
        


        //update conversation bool
        if (sentences.Count == 0)
        {
            conversationEnded = true;
        }

    }

    private void StartConversation(DialogueManager dialogueManager)
    {
        //activate gameobject
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }

        //update the speaker name
        //playerNameText.text = dialogueManager.playerName;

        //add dialogue text to the queue
        for (int i = 0; i < dialogueManager.sentences.Length; i++)
        {
            sentences.Enqueue(dialogueManager.sentences[i]);
        }

 
    }

    private void EndConversation()
    {
        //clear the queue

        //return bool to false
        conversationEnded = false;

        //deactivate gameobject
        if (gameObject.activeSelf)
        {
            gameObject.SetActive (false);
        }
    }

    private IEnumerator TypeDialogueManager(string p)
    {
        Debug.Log("Typing started");

        isTyping = true;

        SpeakText.text = "";

        *//*string originalText = p;
        string displayedText = "";
        int alphaIndex = 0;*//*

        foreach (char c in p*//*.ToCharArray()*//*)
        {
            *//*alphaIndex++;
            SpeakText.text = originalText;

            displayedText = SpeakText.text.Insert(alphaIndex, HTML_ALPHA);
            SpeakText.text = displayedText;*//*
            SpeakText.text = "HELLO";
            yield return new WaitForSeconds(0.05f);
            SpeakText.text = "WORLD";

            //yield return new WaitForSeconds(MAX_TYPE_TIME / typeSpeed);
        }

        isTyping = false;
       
    }

    private void FinishSentenceEarly()
    {
        //stop the coroutine 
        StopCoroutine(typeDialogueCoroutine);

        //finish displaying text
        SpeakText.text = p;

        //update isTyping bool
        isTyping = false;
    }



*/


}
