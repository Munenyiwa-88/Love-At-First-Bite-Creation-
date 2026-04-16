using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

//The dialoguemanager class will manage all the dialogue inputed into the dialoguetrigger script
public class DialogueManager : MonoBehaviour
{
    //Creating dialogue manager instance, to access class from any point of the game
    public static DialogueManager Instance;

    //References to UI components, name, icon, dialogue line.

    public Image characterIcon;
    public TextMeshProUGUI characterName;
    public TextMeshProUGUI dialogueArea;


    private void Start()
    {
        if (Instance == null)
            Instance = this;
    }

}
