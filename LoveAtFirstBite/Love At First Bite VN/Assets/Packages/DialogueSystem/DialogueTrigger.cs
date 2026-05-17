//using System.Collections.Generic;
//using UnityEngine;

////Dialogue character class to group the name and icon of a character 
//[System.Serializable]
//public class DialogueCharacter
//{
//    public string name;
//    public Sprite icon;
//}

////Dialogue line class with use of dialoguecharcter, string line and a text area for the dialogue
//[System.Serializable]
//public class DialogueLine
//{
//    public DialogueCharacter character;
//    [TextArea(1, 5)]
//    public string line;
//}

////Dialogue class with list of the created dialogue
//[System.Serializable]
//public class Dialogue
//{
//    public List<DialogueLine> dialogueLines = new List<DialogueLine>();
//}

////Where public dialogue will be made
//public class DialogueTrigger : MonoBehaviour
//{
//    public Dialogue dialogue;

//    //Triggerdialogue method that will call on the startdialogue from the dialogue manager
//    public void TriggerDialogue()
//    {
//        DialogueManager.Instance.StartDialogue(dialogue);
//    }

//    //OnTriggerEnter2D, two check on player collision and when they trigger dialogue
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.tag == "Player")
//        {
//            TriggerDialogue();
//        }
//    }
//}
