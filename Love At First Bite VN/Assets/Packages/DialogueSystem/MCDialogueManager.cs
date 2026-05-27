using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MCDialogueManager : MonoBehaviour
{

    [Header("MainUI")]
    //Calling the main objects for the dialogue
    public TextMeshProUGUI croissantDialogueText;
    public TextMeshProUGUI playerDialogueText;
    public Button nextButton;
    public Button nextPlayerButton;
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
    public GameObject croissantDialogueBoxImage;
    public GameObject playerDialogueBoxImage;
    [Header("Character")]
    public Image characterPanel;
    public GameObject characterIdleImage;
    public GameObject characterHappyImage;
    public GameObject characterSadImage;
    public GameObject characterAngryImage;
    public GameObject characterFlirtyImage;
    /*[Header("HeartMeter")]
    public Image heartMeterPanel;
    public GameObject heartMeterhalfImage;
    public GameObject heartMeter25Image;
    public GameObject heartMeter75Image;
    public GameObject heartMeteremptyImage;
    public GameObject heartMeterfullImage;*/
    //Inputting a slider 
    [Header("Slider")]
    public float heart;
    public float maxHeart = 10;
    public Slider slider;
    //Adding the script for the games audios

    [Header("Audio")]
    [SerializeField] AudioSource MaleBGM;
    [SerializeField] AudioSource MaleGroan;
    [SerializeField] AudioSource MaleGiggle;
    [SerializeField] AudioSource MaleGasp;
    [SerializeField] AudioSource MaleFlirt;
    

    /* [Header("Audio")]
     [SerializeField] AudioSource ThemeSongCreepy;
     [SerializeField] AudioSource ThemeSongBGM;
     [SerializeField] AudioSource GirlGiggle;
     [SerializeField] AudioSource GirlDisgust;
     [SerializeField] AudioSource ButtonFeedback;
     [SerializeField] AudioSource HeartMeterIncrease;
     [SerializeField] AudioSource HeartMeterDecrease;*/
    [Header("Player Name")]
    //Input player name typing method
    private string playerName;
    /* [Header("Player Dialogue Box Name")]
     public TextMeshProUGUI nameText;*/
    //List of strings (List of all of my dialogue lines) - [] - this is what creates the list
    [Header("Sentences List")]
    public string[] sentences;

   /* public void SetName(string name)
    {
        playerName = name;
        nameText.text = name;
        nameText.text.Replace("{Name}", playerName);
        return;
    }

*/


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
        croissantDialogueBoxImage.SetActive(true);
        playerDialogueBoxImage.SetActive(false);

        //declaring the songs 
        /*ThemeSongCreepy.Stop();
        ThemeSongBGM.Play();
        GirlDisgust.Stop();
        GirlGiggle.Play();
        ButtonFeedback.Stop();
        HeartMeterIncrease.Stop();
        HeartMeterDecrease.Stop();*/

        currentIndex = 0;
        croissantDialogueText.text = sentences[currentIndex];
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
        if (currentIndex == 10)
        {
            backgroundAfternoonPanel.sprite = backgroundAfternoonImage;
        }

        if (currentIndex == 23)
        {
            backgroundNightPanel.sprite = backgroundNightImage;
        }

        //the line code for the dialogue box's
        if (currentIndex == 0)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 1)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 3)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 8)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 9)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 13)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 14)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 17)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 18)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 22)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 23)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 26)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 27)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 29)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 30)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 32)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 33)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 34)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 35)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 36)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 37)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 38)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 39)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 40)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 41)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 42)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 43)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 45)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 46)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 50)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 51)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 53)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 54)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 55)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 56)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }

        if (currentIndex == 59)
        {
            croissantDialogueBoxImage.SetActive(false);
            playerDialogueBoxImage.SetActive(true);
        }

        if (currentIndex == 60)
        {
            croissantDialogueBoxImage.SetActive(true);
            playerDialogueBoxImage.SetActive(false);
        }


        //the line of code that will change the chaarcters expression. So what is said for the characters visual to change
        //IDLE
        if (currentIndex == 22)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 47)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);

        }

        // ANGRY
        if (currentIndex == 15)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 39)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 61)
        {
            characterAngryImage.SetActive(true);
            characterHappyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        //HAPPY
        if (currentIndex == 27)
        {
            characterHappyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 58)
        {
            characterHappyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterFlirtyImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        //FLIRTY
        if (currentIndex == 43)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 56)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        if (currentIndex == 60)
        {
            characterFlirtyImage.SetActive(true);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
            characterSadImage.SetActive(false);
        }

        //SAD
        if (currentIndex == 19)
        {
            characterSadImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        if (currentIndex == 25)
        {
            characterSadImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        if (currentIndex == 30)
        {
            characterSadImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        if (currentIndex == 62)
        {
            characterSadImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterIdleImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }
         //adding audio to charcter expresions
        //SAD AUDIO  

        if (currentIndex == 19)
        {
            MaleGroan.Play();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Stop();
        }

        if (currentIndex == 25)
        {
            MaleGroan.Play();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Stop();
        }

        if (currentIndex == 30)
        {
            MaleGroan.Play();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Stop();
        }

        if (currentIndex == 62)
        {
            MaleGroan.Play();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Stop();
        }

        //FLIRTY AUDIO

        if (currentIndex == 43)
        {
            MaleGroan.Stop();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Play();
        }

        if (currentIndex == 56)
        {
            MaleGroan.Stop();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Play();
        }

        if (currentIndex == 60)
        {
            MaleGroan.Stop();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Play();
        }

        //HAPPY AUDIO

        if (currentIndex == 27)
        {
            MaleGroan.Stop();
            MaleGiggle.Play();
            MaleGasp.Stop();
            MaleFlirt.Stop();
        }

        if (currentIndex == 58)
        {
            MaleGroan.Stop();
            MaleGiggle.Play();
            MaleGasp.Stop();
            MaleFlirt.Stop();
        }

        //ANGRY AUDIO

        if (currentIndex == 15)
        {
            MaleGroan.Stop();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Play();
        }

        if (currentIndex == 39)
        {
            MaleGroan.Stop();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Play();
        }

        if (currentIndex == 61)
        {
            MaleGroan.Stop();
            MaleGiggle.Stop();
            MaleGasp.Stop();
            MaleFlirt.Play();
        }



        //SetActive the creepy song that appears at the end of the game
        /* if (currentIndex == 16)
         {
             ThemeSongCreepy.Play();
             GirlDisgust.Stop();
             GirlGiggle.Stop();
             ButtonFeedback.Stop();
             HeartMeterIncrease.Stop();
             HeartMeterDecrease.Stop();
         }*/

    }

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

        if (heart > maxHeart)
        {
            heart = maxHeart;
        }

        slider.value = heart;
    }


    public void DecreaseHeart(float amount)
    {

        Debug.Log("Called");

        heart -= amount;

        if (heart < 0)
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
        if (currentIndex == 11 || currentIndex == 13 || currentIndex == 19)
        {
            currentIndex = 22;
            UpdateUI();
            //return means to cut the method here. So will not continue to 10 onwards. 
            return;
        }
        //If the player chooses any of three options the next button should take them to 15
        if (currentIndex == 24 || currentIndex == 27 || currentIndex == 30)//(currentIndex == 8)
        {
            currentIndex = 38;
            UpdateUI();
            return;
        }
        //If the player chooses any of three options the next button should take them to 15
        if (currentIndex == 39 || currentIndex == 43 || currentIndex == 47)
        {
            currentIndex = 55;
            UpdateUI();
            return;
        }
        //If the player is on Index 21 skip 10 and go to 35
        if (currentIndex == 58)
        {
            currentIndex = 59;
            UpdateUI();
            return;
        }
        //If the player is on Index 21 skip 10 and go to 35
        if (currentIndex == 61)
        {
            currentIndex = 62;
            UpdateUI();
            return;
        }

        //If we are at 20, end of Yes path || 27 end of No path
        if (currentIndex == 60 || currentIndex == 62)
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

        List<float> goodChoices = new List<float>() { 11, 27, 43, 58 };
        List<float> badChoice = new List<float>() { 15, 24, 30, 39, 61 };

        //10,12,13
        //what good index choice was pressed
        if (idx == 11 || idx == 27 || idx == 43 || idx == 58)
        {
            AddHeart(2.5f);
        }

        if (idx == 15 || idx == 24 || idx == 30 || idx == 39)
        {
            DecreaseHeart(2.5f);
        }

        if (idx == 58)
        {
            AddHeart(5);
        }

        if (idx == 61)
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
        croissantDialogueText.text = currentText;
        playerDialogueText.text = currentText;
        //reset all the panels so that they do not overlap
        nameInputPanel.SetActive(false);
        choicesPanel1.SetActive(false);
        choicesPanel2.SetActive(false);
        choicesPanel3.SetActive(false);
        choicesPanel4.SetActive(false);
        nextButton.gameObject.SetActive(true);
        nextPlayerButton.gameObject.SetActive(true);
        //endButton.gameObject.SetActive(false);


        //Events- For typing and choices
        //Will Ask for a name at index 1

        //First branching at index 5
        if (currentIndex == 5)
        {
            nextButton.gameObject.SetActive(false);
            nameInputPanel.SetActive(true);
            nextPlayerButton.gameObject.SetActive(false);

        }


        else if (currentIndex == 10)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel1.SetActive(true);
        }

        //Second branching at index 17
        else if (currentIndex == 23)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel2.SetActive(true);
        }

        //Second branching at index 15
        else if (currentIndex == 38)
        {
            nextButton.gameObject.SetActive(false);
            choicesPanel3.SetActive(true);
        }

        //Second branching at index 37
        else if (currentIndex == 57)
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
        if (currentIndex == 60)
        {
            goodEndButton.gameObject.SetActive(true);
            badEndButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(false);

            SceneManager.LoadScene("GoodEndingMC");
        }

        if (currentIndex == 62)
        {
            badEndButton.gameObject.SetActive(true);
            goodEndButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(false);

            SceneManager.LoadScene("BadEndingMC");
        }

    }

    private void EndGame()
    {
        Debug.Log("Game has ended");
        nextButton.gameObject.SetActive(false);

        if (currentIndex == 60)
        {
            goodEndButton.gameObject.SetActive(true);
            //SceneManager.LoadScene("GoodEnding");
        }

        if (currentIndex == 62)
        {
            badEndButton.gameObject.SetActive(true);
            //SceneManager.LoadScene("BadEnding");
        }



        //we are gonna hide the ui
    }


}
