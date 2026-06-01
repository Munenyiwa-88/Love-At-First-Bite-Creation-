/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    private TMP_Text TextBox;

    char[] Letters;

    struct DialogueRequest
    {
        public float StartDelay;
        public float ReadTime;
        public string Dialogue;
        public string sentences;
        public string currentIndex;
    }

    List<DialogueRequest> Stack = new List<DialogueRequest>();

    private void Start()
    {
        TextBox = this.gameObject.GetComponent<TextMeshProUGUI>();
        TextBox.text = "";
    }

    public float LetterDelay;
    public float RemoveDelay;

    public void TextRequest(float StartDelay, string Dialogue, float ReadTime)
    {
        DialogueRequest NewRequest = new DialogueRequest();
        NewRequest.StartDelay = StartDelay;
        NewRequest.ReadTime = ReadTime;
        NewRequest.Dialogue = Dialogue;
        Stack.Add(NewRequest);

        if (Stack.Count == 1)
        {
            Letters = Stack[0].Dialogue.ToCharArray();
            StartCoroutine("AddChar", StartDelay);
        }
    }












}

*/






