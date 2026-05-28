using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
    public Button goodEndButton;
    public Button badEndButton;
    //public Button endButton;
    public TMP_InputField nameInputField;
    //The current text number
    public int currentIndex = 0;
    [Header("Panels")]
    //Inputting the dialogue choices panel
    public GameObject choicesPanel1;
    public GameObject choicesPanel2;
    public GameObject choicesPanel3;
    public GameObject choicesPanel4;
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
    public GameObject characterSadImage;
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
    public float heart;
    public float maxHeart = 10;
    public Slider slider;
    //Adding the script for the games audios
    //[Header("Audio")]
    //[SerializeField] AudioSource ThemeSongCreepy;
    //[SerializeField] AudioSource ButtonFeedback;
    //[SerializeField] AudioSource HeartMeterIncrease;
    //[SerializeField] AudioSource HeartMeterDecrease; 
     
    [Header("Audio")]
    [SerializeField] AudioSource GirlBGM;
    [SerializeField] AudioSource GirlGiggle;
    [SerializeField] AudioSource GirlDisgust;
    [SerializeField] AudioSource GirlGasp;
    [SerializeField] AudioSource GirlSigh;
    [SerializeField] AudioSource GirlAngry;

    [Header("Player Name")]
    //Input player name typing method
    private string playerName;
   /* [Header("Player Dialogue Box Name")]
    public TextMeshProUGUI nameText;*/
    //List of strings (List of all of my dialogue lines) - [] - this is what creates the list
    [Header("Sentences List")]
    public string[] sentences;

   /* [Header("Text Settings")]
    [SerializeField] [TextArea] private string itemInfo;
    [SerializeField] private float textSpeed = 0.03f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    private int currenDisplayingText = 0;

    public void ActivateText()
    {
        //start coroutine
        StartCoroutine(AnimateText()); 
        
    }

    IEnumerator AnimateText()
    {
        for (int i = 0; i < itemInfo[currentIndex].Length + 1; i++)
        {
            itemInfoText.text = itemInfo[currenDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
        }
    }*/

   /* public void SetName(string name)
    {
        playerName = name; 
        nameText.text = name;
        nameText.text.Replace("{Name}", playerName);
        return;
    }*/




    public void Start()
    {
        characterHappyImage.SetActive(false);
        characterAngryImage.SetActive(false);
        characterFlirtyImage.SetActive(false);
        characterSadImage.SetActive(false);
        //dialoguePlayerBoxImage.SetActive(false);

        /*heartMeterfullImage.SetActive(false);
        heartMeter25Image.SetActive(false);
        heartMeter75Image.SetActive(false);
        heartMeterhalfImage.SetActive(true);
        heartMeteremptyImage.SetActive(false);*/

        //slider 
        heart = maxHeart;
        slider.maxValue = maxHeart;
        slider.value = heart;


        SetHeart(5);

        //dialogue box's SetActive fasle or true
        raspberryDialogueBoxImage.SetActive(true);
        playerDialogueBoxImage.SetActive(false);

        //declaring the songs 
        //ThemeSongCreepy.Stop();
        //ThemeSongBGM.Play();
        //GirlDisgust.Stop();
        //GirlGiggle.Play();
        //ButtonFeedback.Stop();
        //HeartMeterIncrease.Stop();  
        //HeartMeterDecrease.Stop();

      
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
        if (currentIndex == 12 /*|| currentIndex == 7 || currentIndex == 8*/)
        {
            backgroundAfternoonPanel.sprite = backgroundAfternoonImage;
        }

        if (currentIndex == 25)
        {
            backgroundNightPanel.sprite = backgroundNightImage;
        }

        //the line code for the dialogue box's
        if (currentIndex == 0)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }
        
        if (currentIndex == 2)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 3)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 4)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 18)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 19)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 24)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 25)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 26)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 27)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 31)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 33)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 39)
        {
            raspberryDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 40)
        {
            raspberryDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        //the line of code that will change the chaarcters expression. So what is said for the characters visual to change
        //IDLE
        if (currentIndex == 9)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 11)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);

        }

        if (currentIndex == 13)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 16)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 23)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        // ANGRY
        if (currentIndex == 12)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 22)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 29)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 41)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        //HAPPY
        if (currentIndex == 8)
        {
            characterHappyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 38)
        {
            characterHappyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        //FLIRTY
        if (currentIndex == 14)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 27)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 35)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        //SAD
        if (currentIndex == 10)
        {
            characterSadImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        if (currentIndex == 24)
        {
            characterSadImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }
         //adding audio to character expressions
         //Sad

        if (currentIndex == 10)
        {
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            GirlGasp.Stop();
            GirlSigh.Play();
            GirlAngry.Stop();
        }

        if (currentIndex == 24)
        {
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            GirlGasp.Stop();
            GirlSigh.Play();
            GirlAngry.Stop();
        }

        //angry

        if (currentIndex == 12)
        {
            GirlDisgust.Play();
            GirlGiggle.Stop();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Stop();
        }

        if (currentIndex == 22)
        {
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Play();
        }

        if (currentIndex == 29)
        {
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Play();
        }

        if (currentIndex == 41)
        {
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Play();
        }

        //Happy

        if (currentIndex == 8)
        {
            GirlDisgust.Stop();
            GirlGiggle.Play();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Stop();
        }

        if (currentIndex == 38)
        {
            GirlDisgust.Stop();
            GirlGiggle.Play();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Stop();
        }

        //flirty

        if (currentIndex == 14)
        {
            GirlDisgust.Stop();
            GirlGiggle.Play();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Stop();
        }

        if (currentIndex == 27)
        {
            GirlDisgust.Stop();
            GirlGiggle.Play();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Stop();
        }

        if (currentIndex == 35)
        {
            GirlDisgust.Stop();
            GirlGiggle.Play();
            GirlGasp.Stop();
            GirlSigh.Stop();
            GirlAngry.Stop();
        }

        
        //SetActive the creepy song that appears at the end of the game
        /*if (currentIndex == 16)
        {
            ThemeSongCreepy.Play();
            GirlDisgust.Stop();
            GirlGiggle.Stop();
            ButtonFeedback.Stop();
            HeartMeterIncrease.Stop();
            HeartMeterDecrease.Stop();
        }

       /* //for the textlength 
        textLength = TextCreator.charCount;*/
    }

    /* IEnumerator EventStarter()
     {
         mainTextObject.SetActive(true);
         textToSpeak = "This is a dialogue line...";
         raspberryDialogueText.GetComponent<TMPro.TMPro_Text>().text = textToSpeak;
         currentTextLength = textToSpeak.Length;
         TextCreator.runTextPrint = true;
         yield return new WaitForSeconds(0.05f);
         yield return new WaitForSeconds(1);
         yield return new WaitUntil(() => textLength == currentTextLength);
         yield return new WaitForSeconds(0.5f);


     }
 */
    //class for the sllider
    public void HeartMeter(float amount)
    {
        heart -= amount;
        slider.value = heart;
        slider.minValue = 0;
        slider.maxValue = 10;
        //slider.value = 5;
    }


    public void AddHeart(float amount)
    {
        heart += amount;

        Debug.Log("Called");

        if(heart > maxHeart)
        {
            heart = maxHeart;
        }

        slider.value = heart;
    }


    public void DecreaseHeart(float amount)
    {

        Debug.Log("Called");

        heart -= amount;

        if(heart < 0)
        {
            heart = 0;
        }

        slider.value = heart;
    }

    public void SetHeart(float amount)
    {
        heart = amount;
        slider.value = heart;
    }

    //class for showing the next sentences after button is pressed
    public void ShowNextSentence()
    {
        //If player chooses Vanilla start at 6 or Strawberry at 7 then send both to 9
        // the two lines - || mean or
        // == means asking/checking = means setting the value 

        //choice 1
        if (currentIndex == 8 || currentIndex == 9 || currentIndex == 10)
        {
            currentIndex = 11;
            UpdateUI();
            //return means to cut the method here. So will not continue to 10 onwards. 
            return;
        }
        //If the player chooses any of three options the next button should take them to 15
        if (currentIndex == 12 || currentIndex == 13 || currentIndex == 14)//(currentIndex == 8)
        {
            currentIndex = 15;
            UpdateUI();
            return;
        }
        //If the player is on Index 21 skip 10 and go to 35
        if (currentIndex == 21)
        {
            currentIndex = 35;
            UpdateUI();
            return;
        }
        //If the player is on Index 21 skip 10 and go to 35
        if (currentIndex == 28)
        {
            currentIndex = 35;
            UpdateUI();
            return;
        }

        //If we are at 20, end of Yes path || 27 end of No path
        if (currentIndex == 40 || currentIndex == 42)
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
        UpdateSliderWithDialogue(jumpToIndex);
    }

    //private class for all of the individual heart meter reactions. Works alongside the button
    private void UpdateSliderWithDialogue(float idx)
    {

        List<float> goodChoices = new List<float>() { 8, 14, 16, 38 };
        List<float>badChoice = new List<float>() { 10, 12, 22, 13, 29, 41};

        //10,12,13
        //what good index choice was pressed
        if (idx ==  8 || idx == 14 || idx == 16)
        {
            AddHeart(2.5f);
        }

        if (idx == 10 || idx == 12 || idx == 13 || idx == 22 || idx == 29)
        {
            DecreaseHeart(2.5f);
        }

        if (idx == 38)
        {
            AddHeart(5);
        }

        if (idx == 41)
        {
            DecreaseHeart(5);
        }
    }


    private void UpdateUI()
    {
        //so we have a new variable =currentText, current text takes the original sentence - searches for {Name} and if its there it replaces it with the player name variable
        string currentText = sentences[currentIndex].Replace("{Name}", playerName);
        //For name of the player dilaogue box
       /* string processed = sentences[currentIndex].Replace("{Name}", playerName);
        nameText.text = processed;*/
        //This is how we convert the sentence itnto the speak text box.
        raspberryDialogueText.text = currentText;
        playerDialogueText.text = currentText;
        //reset all the panels so that they do not overlap
        nameInputPanel.SetActive(false);
        choicesPanel1.SetActive(false);
        choicesPanel2.SetActive(false);
        choicesPanel3.SetActive(false);
        choicesPanel4.SetActive(false);
        nextButton.gameObject.SetActive(true);
        //endButton.gameObject.SetActive(false);


        //Events- For typing and choices
        //Will Ask for a name at index 1
        if (currentIndex == 5)  
        {
            nextButton.gameObject.SetActive(false);
            nameInputPanel.SetActive(true);
        }

        //First branching at index 5
       else if (currentIndex == 7)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel1.SetActive(true);
        }

        //Second branching at index 17
        else if (currentIndex == 11)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel2.SetActive(true);
        }

        //Second branching at index 15
        else if (currentIndex == 15)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel3.SetActive(true);
        }

        //Second branching at index 37
        else if (currentIndex == 37)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel4.SetActive(true);
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

    public void CutScene()
    {
        if (currentIndex == 40)
        {
            goodEndButton.gameObject.SetActive(true);
            badEndButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(false);

            SceneManager.LoadScene("GoodEnding");
        }

        if (currentIndex == 42)
        {
            badEndButton.gameObject.SetActive(true);
            goodEndButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(false);

            SceneManager.LoadScene("BadEnding");
        }

    }

    private void EndGame()
    {
        Debug.Log("Game has ended");
        nextButton.gameObject.SetActive(false);
        
        if (currentIndex == 40)
        {
            goodEndButton.gameObject.SetActive(true);
            //SceneManager.LoadScene("GoodEnding");
        }

        if (currentIndex == 42)
        {
            badEndButton.gameObject.SetActive(true);
            //SceneManager.LoadScene("BadEnding");
        }
       
        

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
        
    10.  //the line of code that will change the chaarcters heartmeter, based off dialogue choice
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
