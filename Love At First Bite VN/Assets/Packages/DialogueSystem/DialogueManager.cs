using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



//The dialoguemanager class will manage all the dialogue inputed into the dialoguetrigger script
public class DialogueManager : MonoBehaviour
{
    [Header("MainUI")]
    //Calling the main objects for the dialogue
    public TextMeshProUGUI raspberryDialogueText;
    public TextMeshProUGUI playerDialogueText;
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
    [Header("DialogueBox")]
    public Image dialogueBoxPanel;
    public GameObject raspberryDialogueBoxImage;
    public GameObject playerDialogueBoxImage;
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
    public GameObject heartMeteremptyImage;
    public GameObject heartMeterfullImage;
    //Inputting a slider 
    [Header("Slider")]
    public int heart;
    public int maxHeart = 10;
    public Slider slider;
    //Adding the script for the games audios
    [Header("Audio")]
    [SerializeField] AudioSource ThemeSongCreepy;
    [SerializeField] AudioSource ThemeSongBGM;
    [SerializeField] AudioSource GirlGiggle;
    [SerializeField] AudioSource GirlDisgust;
    [SerializeField] AudioSource ButtonFeedback;
    [SerializeField] AudioSource HeartMeterIncrease;
    [SerializeField] AudioSource HeartMeterDecrease;
    [Header("Player Name")]
    //Input player name typing method
    private string playerName;
    /*[Header("Player Dialogue Box Name")]
    public TextMeshProUGUI nameText;*/
    //List of strings (List of all of my dialogue lines) - [] - this is what creates the list
    [Header("Sentences List")]
    public string[] sentences;

    /*public void SetName(string name)
    {
        playerName = name; 
        nameText.text = name;
    }*/




    public void Start()
    {
        characterHappyImage.SetActive(false);
        characterAngryImage.SetActive(false);
        characterFlirtyImage.SetActive(false);
        //dialoguePlayerBoxImage.SetActive(false);
        
        /*heartMeterfullImage.SetActive(false);
        heartMeter25Image.SetActive(false);
        heartMeter75Image.SetActive(false);
        heartMeterhalfImage.SetActive(true);
        heartMeteremptyImage.SetActive(false);*/

        //slider 
        slider.maxValue = maxHeart;
        slider.value = heart;

        //dialogue box's SetActive fasle or true
        raspberryDialogueBoxImage.SetActive(true);
        playerDialogueBoxImage.SetActive(false);

        //declaring the songs 
        ThemeSongCreepy.Stop();
        ThemeSongBGM.Play();
        GirlDisgust.Stop();
        GirlGiggle.Play();
        ButtonFeedback.Stop();
        HeartMeterIncrease.Stop();  
        HeartMeterDecrease.Stop();

      
        currentIndex = 0;
        raspberryDialogueText.text = sentences[currentIndex];
        //set the text and current index to the first sentence
        if (currentIndex > 0)
        {
            UpdateUI();
        }
        
        currentIndex = 0;
        playerDialogueText.text = sentences[currentIndex];
        //set the text and current index to the first sentence
        if (currentIndex > 0)
        {
            UpdateUI();
        }
    }
    public void Update()
    {
        //the line of code that actually changes the image, it checks if the index is right then changes the image
        if (currentIndex == 6 || currentIndex == 7 || currentIndex == 8)
        {
            backgroundAfternoonPanel.sprite = backgroundAfternoonImage;
        }

        if (currentIndex == 17)
        {
            backgroundNightPanel.sprite = backgroundNightImage;
        }

        //the line code for the dialogue box's
        if (currentIndex == 12)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }
        
        if (currentIndex == 13)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 15)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 16)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 21)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 22)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 25)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 26)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 27)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
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

        if (currentIndex == 10)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        /* //the line of code that will change the chaarcters heartmeter, based off dialogue choice
         if (currentIndex == 0)
         {
             heartMeterhalfImage.SetActive(true); 
         }

         if (currentIndex == 6 || currentIndex == 7)
         {
             heartMeter25Image.SetActive(true);
         }

         if (currentIndex == 8)
         {
             heartMeter75Image.SetActive(true);
         }


         if (currentIndex == 21)
         {
             heartMeteremptyImage.SetActive(true);
         }

         if (currentIndex == 18)
         {
             heartMeterfullImage.SetActive(true);
         }*/


        if (currentIndex == 0)
        {
            slider.value = 5;
        }
        else if (currentIndex == 6 || currentIndex == 7)
        {
            slider.value = 2.5f;
        }
        else if (currentIndex == 8)
        {
            slider.value = 7.5f;
        }
        else if (currentIndex == 21)
        {
            slider.value = 0;
        }
        else if (currentIndex == 18)
        {
            slider.value = 10;
        }

        //SetActive the creepy song that appears at the end of the game
        if (currentIndex == 16)
        {
            ThemeSongCreepy.Play();
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            ButtonFeedback.Stop();
            HeartMeterIncrease.Stop();
            HeartMeterDecrease.Stop();
        }

    }

    //class for the sllider
    public void HeartMeter(int amount)
    {
        heart -= amount;
        slider.value = heart;


    }

    //class for showing the next sentences after button is pressed
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
        //For name of the player dilaogue box
        //string processed = sentences[currentIndex].Replace("{Name}", playerName);
        //nameText.text = processed;
        //This is how we convert the sentence itnto the speak text box.
        raspberryDialogueText.text = currentText;
        playerDialogueText.text = currentText;
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
        nextButton.gameObject.SetActive(false);
        SceneManager.LoadScene("Choiceofending");

        //we are gonna hide the ui
    }


    /*The things that did not work, with Prototype 1: 
     1. Beginning commeands for animation 
    using UnityEngine.Video;
    using JetBrains.Annotations;
    
     2.[Header("CutScenes")]
     public VideoClip badEndingCutScene;
     public VideoClip goodEndingCutText;
     
     3. [Header("DialogueBox")]
    public Image dialoguePlayerBoxPanel;
    public GameObject dialogueRaspberryBoxImage;
    public GameObject dialoguePlayerBoxImage;
     
     4. Heart Meter did not need the SetActive false.
       - for half image
            heartMeter75Image.SetActive(false);
            heartMeter25Image.SetActive(false);
            heartMeterfullImage.SetActive(false);
            heartMeteremptyImage.SetActive(false);
       - for 25 image
            heartMeterfullImage.SetActive(false);
            heartMeterhalfImage.SetActive(false);
            heartMeter75Image.SetActive(false);
            heartMeteremptyImage.SetActive(false);
       - for 75 image
            heartMeter25Image.SetActive(false);
            heartMeterhalfImage.SetActive(false);
            heartMeterfullImage.SetActive(false);
            heartMeteremptyImage.SetActive(false);
       - for empty image
            heartMeter75Image.SetActive(false);
            heartMeter25Image.SetActive(false);
            heartMeterhalfImage.SetActive(false);
            heartMeterfullImage.SetActive(false);
       - for full image
            heartMeterhalfImage.SetActive(false);
            heartMeter75Image.SetActive(false);
            heartMeteremptyImage.SetActive(false);
            heartMeter25Image.SetActive(false);
    
    5. Audio's that we were unable to implement into the game
       //Setting active the games auadio 
        if (currentIndex == 0)
        {
            ThemeSongBGM.Play();
            GirlGiggle.Stop();
            GirlDisgust.Stop();
            ThemeSongCreepy.Stop();
            ButtonFeedback.Stop();
            HeartMeterIncrease.Stop();
            HeartMeterDecrease.Stop();
        }
        if (currentIndex == 2)
        {
            GirlGiggle.Play();
            GirlDisgust.Stop();
            ThemeSongCreepy.Stop();
            ButtonFeedback.Stop();
            HeartMeterIncrease.Stop();
            HeartMeterDecrease.Stop();
        }
    
        if (currentIndex == 22)
        {
            GirlDisgust.Play();
            ThemeSongBGM.Stop();
            GirlGiggle.Stop();
            ButtonFeedback.Stop();
            HeartMeterIncrease.Stop();
            HeartMeterDecrease.Stop();
        }

        if (currentIndex == 22)
        {
            GirlDisgust.Play();
            ThemeSongBGM.Stop();
            GirlGiggle.Stop();
            ButtonFeedback.Stop();
            HeartMeterIncrease.Stop();
            HeartMeterDecrease.Stop();
        }
     
     6. Wanted to include a player dialogue box, however, the coding glitched and did not work 
        //coding that will change the dialogue box in accordance to when the player talks
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
        }

     7. Adding a button that would lead to cutscenes.
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

     8. //public void videobutton () SceneManager.loadscene

        
     9. //will reuse/bring back - if you deactivate it the dialogue lines will not appear in gameview
        
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
