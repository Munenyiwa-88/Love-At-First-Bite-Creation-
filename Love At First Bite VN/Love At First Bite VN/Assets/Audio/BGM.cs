using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{

    public static BGM instance;

    public AudioSource MainBGM;

    // scene where music pauses 

    public string pauseSceneName = "Dame Framboje";
    public string pausesceneName = "Monsieur Chocolat";
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else

        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        MainBGM = GetComponent<AudioSource>();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == pauseSceneName)
        {
            MainBGM.Pause();
        }
        if (scene.name == pausesceneName)
        {
            MainBGM.Pause();
        }
    }
}
   


