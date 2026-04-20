using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
//using UnityEngine.Video;
//using JetBrains.Annotations;


//The dialoguemanager class will manage all the dialogue inputed into the dialoguetrigger script
public class DialogueManager : MonoBehaviour
{
    [Header("MainUI")]
    //Calling the main objects for the dialogue
    public TextMeshProUGUI dialogueText;
    public Button nextButton;
    //public Button endButton;
    public TMP_InputField nameInputField;
    //The current text number
    public int currentIndex = 0;
    [Header("Panels")]
    //Inputting the dialogue choices panel
    public GameObject choicesPanel1;
    public GameObject choicesPanel2;
    public GameObject dialoguePanel;
    public GameObject nameInputPanel;
    [Header("Backgrounds")]
    public Image backgroundAfternoonPanel;
    public Sprite backgroundAfternoonImage;
    public Image backgroundNightPanel;
    public Sprite backgroundNightImage;
    [Header("Character")]
    public Image characterPanel;
    public GameObject characterIdleImage;
    public GameObject characterHappyImage;
    public GameObject characterAngryImage;
    public GameObject characterFlirtyImage;
    [Header("HeartMeter")]
    public Image heartMeterPanel;
    public GameObject heartMeterhalfImage;
    public GameObject heartMeter25Image;
    public GameObject heartMeter75Image;
    public GameObject heartMeterfullImage;
    [Header("Player Name")]
    //Input player name typing method
    private string playerName;
    //List of strings (List of all of my dialogue lines) - [] - this is what creates the list
    [Header("Sentences List")]
    public string[] sentences;
    //[Header("CutScenes")]
    //public VideoClip badEndingCutScene;
    //public VideoClip goodEndingCutText;
    /*[Header("DialogueBox")]
    public Image dialoguePlayerBoxPanel;
    public GameObject dialogueRaspberryBoxImage;
    public GameObject dialoguePlayerBoxImage;*/






    public void Start()
    {
        characterHappyImage.SetActive(false);
        characterAngryImage.SetActive(false);
        characterFlirtyImage.SetActive(false);
        //dialoguePlayerBoxImage.SetActive(false);
        
        heartMeterfullImage.SetActive(false);
        heartMeter25Image.SetActive(false);
        heartMeter75Image.SetActive(false);

        currentIndex = 0;
        dialogueText.text = sentences[currentIndex];
        //set the text and current index to the first sentence
        if (currentIndex > 0)
        {
            UpdateUI();
        }
    }
    public void Update()
    {
        //the line of code that actually changes the image, it checks if the index is right then changes the image
        if (currentIndex == 6)
        {
            backgroundAfternoonPanel.sprite = backgroundAfternoonImage;
        }

        if (currentIndex == 17)
        {
            backgroundNightPanel.sprite = backgroundNightImage;
        }

        //the line of code that will change the chaarcters expression. So what is said for the characters visual to change
        if (currentIndex == 6)
        {

            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
        }

        if (currentIndex == 7)
        {

            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
        }

        if (currentIndex == 16)
        {

            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
        }

        if (currentIndex == 20)
        {
            characterHappyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
        }

        if (currentIndex == 9)
        {
            characterAngryImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
        }

        if (currentIndex == 22)
        {
            characterAngryImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
        }

        if (currentIndex == 2)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        if (currentIndex == 18)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        if (currentIndex == 9)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }
        
        //the line of code that will change the chaarcters heartmeter, based off dialogue choice
        if (currentIndex == 6 || currentIndex == 7)
        {
            heartMeter25Image.SetActive(true);
            heartMeterfullImage.SetActive(false);
        }

        if (currentIndex == 8)
        {
            heartMeter75Image.SetActive(true);
            heartMeter25Image.SetActive(false);
            heartMeterfullImage.SetActive(false);
        }


        if (currentIndex == 21)
        {
            heartMeterhalfImage.SetActive(true);
            heartMeter75Image.SetActive(false);
            heartMeter25Image.SetActive(false);
            heartMeterfullImage.SetActive(false);
        }

        if (currentIndex == 18)
        {
            heartMeterfullImage.SetActive(true);
            heartMeterhalfImage.SetActive(false);
            heartMeter75Image.SetActive(false);
            heartMeter25Image.SetActive(false);
        }
     

        /*//coding that will change the dialogue box in accordance to when the player talks
        if (currentIndex == 1)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false); 
        }

        if (currentIndex == 2)
        {
            dialogueRaspberryBoxImage.SetActive(true);
            dialoguePlayerBoxImage.SetActive(false);
        }

        if (currentIndex == 12)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false);
        }

        if (currentIndex == 13)
        {
            dialogueRaspberryBoxImage.SetActive(true);
            dialoguePlayerBoxImage.SetActive(false);
        }

        if (currentIndex == 15)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false);
        }

        if (currentIndex == 16)
        {
            dialogueRaspberryBoxImage.SetActive(true);
            dialoguePlayerBoxImage.SetActive(false);
        }

        if (currentIndex == 18)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false);
        }

        if (currentIndex == 19)
        {
            dialogueRaspberryBoxImage.SetActive(true);
            dialoguePlayerBoxImage.SetActive(false);
        }

        if (currentIndex == 21)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false);
        }

        if (currentIndex == 22)
        {
            dialogueRaspberryBoxImage.SetActive(true);
            dialoguePlayerBoxImage.SetActive(false);
        }

        if (currentIndex == 25)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false);
        }

        if (currentIndex == 26)
        {
            dialogueRaspberryBoxImage.SetActive(true);
            dialoguePlayerBoxImage.SetActive(false);
        }

        if (currentIndex == 27)
        {
            dialoguePlayerBoxImage.SetActive(true);
            dialogueRaspberryBoxImage.SetActive(false);
        }*/
    }


    public void ShowNextSentence()
    {
       
        //If player chooses Vanilla start at 6 or Strawberry at 7 then send both to 9
        // the two lines - || mean or
        // == means asking/checking = means setting the value 
        if (currentIndex == 6 || currentIndex == 7)
        {
            currentIndex = 9;
            UpdateUI();
            //return means to cut the method here. So will not continue to 10 onwards. 
            return;
        }
        //If the player chooses Raspberry 3 at 8 send them to 10
        if (currentIndex == 8)
        {
            currentIndex = 10;
            UpdateUI();
            return;
        }
        //If the player is on Index 9 skip 10 and go to 11
        if (currentIndex == 9)
        {
            currentIndex = 11;
            UpdateUI();
            return;
        }
       //If we are at 20, end of Yes path || 27 end of No path
        if (currentIndex == 20 || currentIndex == 27)
        {
            EndGame();
            return;
        }

        //check if we aren't at the end of the array/list
        if (currentIndex < sentences.Length - 1)
        {
            currentIndex++;
            UpdateUI();
        }
        else
        {
            EndGame();
        }

    }

    //Method for different branching dialogues. Connecting choice to responses
    //Adding parameters, to help jump to different responses in dialogue
    public void MakeChoice(int jumpToIndex)
    {
        currentIndex = jumpToIndex;
        UpdateUI();
    }

    private void UpdateUI()
    {
        //so we have a new variable =currentText, current text takes the original sentence - searches for {Name} and if its there it replaces it with the player name variable
        string currentText = sentences[currentIndex].Replace("{Name}", playerName);
        //This is how we convert the sentence itnto the speak text box.
        dialogueText.text = currentText;
        //reset all the panels so that they do not overlap
        nameInputPanel.SetActive(false);
        choicesPanel1.SetActive(false);
        choicesPanel2.SetActive(false);
        nextButton.gameObject.SetActive(true);
        //endButton.gameObject.SetActive(false);


        //Events- For typing and choices
        //Will Ask for a name at index 1
        if (currentIndex == 1)  
        {
            nextButton.gameObject.SetActive(false);
            nameInputPanel.SetActive(true);
        }

        //First branching at index 5
       else if (currentIndex == 5)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel1.SetActive(true);
        }

        //Second branching at index 17
        else if (currentIndex == 17)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel2.SetActive(true);
        }

        //Condition for the next button to change into an end button and show the cutscenes
        //If current index == 27 { next button false then set active the next button that will play video}

        /*void DownloadManager VideoClip;{

    }

        
        if (currentIndex == 27)
        {
            endButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(false);
        }

        if (currentIndex == 20)
        {
            endButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(false);
        }

        //public void videobutton () SceneManager.loadscene
        */

        /*
        //will reuse/bring back - if you deactivate it the dialogue lines will not appear in gameview
        
        //We will check if we have reached the very last sentence
        if (currentIndex == sentences.Length - 1)
        {
            //activate play button and deactivate next button
            //load another scene;
        }
        else
        {
            //Keep next button 
        }
        */
    }

    public void confirmName()
    {
        //exclamation marks turns the entire logic negetive, its basically the opposite pf what will be in the brackets 
        if (!string.IsNullOrEmpty(nameInputField.text))
        {
            playerName = nameInputField.text;
        }     
        ShowNextSentence();
    }

    private void EndGame()
    {
        Debug.Log("Game has ended");

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
