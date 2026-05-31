/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

*//*public class TextCreator : DialogueManager, ITalkable
{
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private DialogueController dialogueController;

    public void Interact()
    {
        Talk(dialogueManager);
    }

    public void Talk(DialogueManager dialoguemanager)
    {
       //start conversation
       dialogueController.ShowNextSentence(dialogueManager);
    }



*/




    /* public static TMPro.TMP_Text viewText;
    public static bool runTextPrint;
    public static int charCount;
    [SerializeField] string transferText;
    [SerializeField] int internalCount;


    // Update is called once per frame
    void Update()
    {
       internalCount = charCount;
       charCount = GetComponent<TMPro.TMP_Text>().text.Length;
       
       if (runTextPrint == true)
        {
            runTextPrint = false;
            viewText = GetComponent<TMPro.TMP_Text>();
            transferText = viewText.text;
            viewText.text = "";
            StartCoroutine(RollText());

        }
    }

    IEnumerator RollText()
    {
        foreach (char c in transferText)
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.05f);
        }
    }

*//*











}*/
