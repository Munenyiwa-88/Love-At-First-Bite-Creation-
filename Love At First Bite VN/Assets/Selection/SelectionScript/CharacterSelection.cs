using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    public Button cupcakeButton;
    public Button croissantButton;

    public void OnCupcakeButton()
    {
        SceneManager.LoadScene("CupcakeConfirmation");
    }

    public void OnCroissantButton()
    {
        SceneManager.LoadScene("CroissantConfirmation");
    }

}
