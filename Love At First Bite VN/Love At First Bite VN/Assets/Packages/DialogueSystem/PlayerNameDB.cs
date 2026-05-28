using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Text obj_text;
    public InputField display;

    private void Start()
    {
        obj_text.text = PlayerPrefs.GetString("{Name}");
    }

    public void Create()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("{Name}", obj_text.text);
        PlayerPrefs.Save();
    }








































    /*[Header("Player Name")]
    //Input player name typing method
    private string playerName;
    [Header("Player Dialogue Box Name")]
    public TextMeshProUGUI nameText;

    public void SetName(string name)
    {
        playerName = name;
        nameText.text = name;
        nameText.text.Replace("{Name}", playerName);
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
