using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CroissantChoiceConfirmation : MonoBehaviour
{
    
    public Button yesButton;
    public Button noButton;
    
    public void OnYesButton()
    {
       SceneManager.LoadScene("MonsieurChocolat");
    }

    public void OnNoButton()
    {
       SceneManager.LoadScene("CharacterSelection");
    }


}


