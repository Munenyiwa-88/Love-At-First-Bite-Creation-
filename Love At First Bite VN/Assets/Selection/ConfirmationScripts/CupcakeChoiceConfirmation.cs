using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CupcakeChoiceConfirmation : MonoBehaviour
{
   
    public Button yesButton;
    public Button noButton;
    public AudioSource MainBGM;

    public void OnYesButton()
    {
        SceneManager.LoadScene("DameFramboje");
        MainBGM.Pause();
    }

    public void OnNoButton()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

}
