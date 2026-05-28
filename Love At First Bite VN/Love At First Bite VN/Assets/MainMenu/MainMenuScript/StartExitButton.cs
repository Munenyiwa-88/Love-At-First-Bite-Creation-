using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartExitButton : MonoBehaviour
{
    //Calling the UI buttons that will be used for the main menu
    public Button startButton;
    public Button exitButton;

    //To help manage the start and exit button and the clicking of it
    public void OnStartClick()
    {
        SceneManager.LoadScene("Prologue");
    }

    //So that players can go back to the Main Menu with the exit to main menu button
    public void GoTomainMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    //Using conditional compilations, as to ensure that the code strictly runs and ends within the compilations 
    public void OnExitClick()
    {
        //SceneManager.LoadScene("GameMenu");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

}
