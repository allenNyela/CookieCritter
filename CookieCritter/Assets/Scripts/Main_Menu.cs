using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Main_Level");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Main_Level");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Mini_Game_1");
    }
}
