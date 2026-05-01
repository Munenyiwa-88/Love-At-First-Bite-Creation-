using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MCDialogueManager : MonoBehaviour
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
    public GameObject heartMeteremptyImage;
    public GameObject heartMeterfullImage;
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
    //List of strings (List of all of my dialogue lines) - [] - this is what creates the list
    [Header("Sentences List")]
    public string[] sentences;






    public void Start()
    {
        characterHappyImage.SetActive(false);
        characterAngryImage.SetActive(false);
        characterFlirtyImage.SetActive(false);
        //dialoguePlayerBoxImage.SetActive(false);

        heartMeterfullImage.SetActive(false);
        heartMeter25Image.SetActive(false);
        heartMeter75Image.SetActive(false);
        heartMeterhalfImage.SetActive(true);
        heartMeteremptyImage.SetActive(false);

        //declaring the songs 
        ThemeSongCreepy.Stop();
        ThemeSongBGM.Play();
        GirlDisgust.Stop();
        GirlGiggle.Play();
        ButtonFeedback.Stop();
        HeartMeterIncrease.Stop();
        HeartMeterDecrease.Stop();


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
        if (currentIndex == 6 || currentIndex == 7 || currentIndex == 8)
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

        if (currentIndex == 10)
        {
            characterIdleImage.SetActive(true);
            characterFlirtyImage.SetActive(false);
            characterHappyImage.SetActive(false);
            characterAngryImage.SetActive(false);
        }

        //the line of code that will change the chaarcters heartmeter, based off dialogue choice
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
    }

}
