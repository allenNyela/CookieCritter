using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public GameObject backgroundMusic;
    // Start is called before the first frame update

    private static AudioManager instance;

    public static new AudioManager Instance
    {
        get
        {
            if (instance == null)
                Debug.LogError("Game Manager is Null");
            return instance;
        }
    }
    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += (scene, mode) => OnSceneLoaded(scene, mode);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Main_Menu" && Instance == this)
        {
            Destroy(gameObject);
        }
    }

}
