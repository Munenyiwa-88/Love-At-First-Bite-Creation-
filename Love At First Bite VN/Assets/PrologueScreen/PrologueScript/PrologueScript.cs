using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrologueScript : MonoBehaviour
{
    //Calling the UI buttons that will be used for the main menu
    public Button startButton;

    //To help manage the start and exit button and the clicking of it
    public void OnStartClick()
    {
        SceneManager.LoadScene("DameFramboje");
    }

}
