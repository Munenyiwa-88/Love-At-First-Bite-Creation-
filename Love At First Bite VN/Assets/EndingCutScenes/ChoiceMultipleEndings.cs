using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/*public class ChoiceMultipleEndings : MonoBehaviour
{
    //Creating Functions for the eat me and let go buttons, for the two endng cutscenes
    public void EatMe()
    {
        //To run an IEnumerator
        StartCoroutine(Make_a_choice_CO(0));
    }

    public void LetGo()
    {
        StartCoroutine(Make_a_choice_CO(1));
    }

    //IEnumerator to ensure that there is a 1 second wait after choice is made
    IEnumerator Make_a_choice_CO(int choice_number)
    {
        if (choice_number == 0)
        {
            //choose 1
            //Using playerpref to save values and data
            //setint saves a interger value inside of a key value 
            PlayerPrefs.SetInt("ending", 0);
        }
        else if (choice_number == 1)
        {
            //choose 2
            PlayerPrefs.SetInt("ending", 1);
        } 
        
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Ending");
        SceneManager.LoadScene("DameFramboje");
          
    }



}*/
