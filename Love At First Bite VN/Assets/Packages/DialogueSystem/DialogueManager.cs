using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


//The dialoguemanager class will manage all the dialogue inputed into the dialoguetrigger script
public class DialogueManager : MonoBehaviour
{
    //Calling the main objects for the dialogue
    public GameObject dialogueBoxPanel;
    public TextMeshProUGUI dialogueText;
    public Button nextButton;
    //List of strings (List of all of my dialogue lines) - [] - this is what creates the list
    public string[] sentences; 

    //The current text number
    public int currentIndex = 0;

    public void Start()
    {
        //set the text and current index to the first sentence
        if (currentIndex < sentences.Length - 1)
        {
            currentIndex++;
            UpdateUI();
        }

    }
    public void Update()
    {
        
    }

    private void UpdateUI()
    {
        dialogueText.text = sentences[currentIndex];
        //We will check if we have reached the very last sentence
        if (currentIndex == sentences.Length - 1)
        {
            //activate play button and deactivate next button
        }
        else
        {
            //Keep next button 
        }
    }

    private void StartGame()
    {
        Debug.Log("The game has started");

        //we are gonna hide the ui
    }










    ////Creating dialogue manager instance, to access class from any point of the game
    //public static DialogueManager Instance;

    ////References to UI components, name, icon, dialogue line.

    //public Image characterIcon;
    //public TextMeshProUGUI characterName;
    //public TextMeshProUGUI dialogueArea;

    ////Create a queue of dialogue lines, order formation
    //private Queue<DialogueLine> lines;

    //public bool isDialogueActive = false;

    //public float typingSpeed = 0.2f;

    //private void Start()
    //{
    //    if (Instance == null)
    //        Instance = this;

    //}

    ////Adding a startdialogue function that will update the state, play an animation and clear queue
    //public void StartDialogue(Dialogue dialogue)
    //{
    //    isDialogueActive = true;

    //    lines.Clear();

    //    foreach (DialogueLine dialogueLine in dialogue.dialogueLines)
    //    {
    //        lines.Enqueue(dialogueLine);
    //    }

    //    DisplayNextDialogueLine();
    //}

    ////A display dialogue line to assist with the dequeing of lines in relation to the sprites & text
    //public void DisplayNextDialogueLine()
    //{
    //    if (lines.Count == 28)
    //    {
    //        EndDialogue();
    //        return;
    //    }

    //    DialogueLine currentLine = lines.Dequeue();

    //    characterIcon.sprite = currentLine.character.icon;
    //    characterName.text = currentLine.character.name;

    //    StopAllCoroutines();

    //    StartCoroutine(TypeSentence(currentLine));
    //}

    //// Typesentence method for empty strings and adding characters to them during animation
    //IEnumerator TypeSentence(DialogueLine dialogueLine)
    //{
    //    dialogueArea.text = "";
    //    foreach (char letter in dialogueLine.line.ToCharArray())
    //    {
    //        dialogueArea.text += letter;
    //        yield return new WaitForSeconds(typingSpeed);
    //    }
    //}

    //void EndDialogue()
    //{
    //    isDialogueActive = false;
    //}

}
