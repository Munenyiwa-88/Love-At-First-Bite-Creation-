using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button quitGame;

    //Using conditional compilations, as to ensure that the code strictly runs and ends within the compilations 
    public void OnQuitClick()
    {
        //SceneManager.LoadScene("GameMenu");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
