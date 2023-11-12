using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    Animator animator;

    Animator controlsPageAnimator;

    Animator controlsButtonAnimator;

    public GameObject controlsPage;

    public GameObject controlsButton;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        controlsPageAnimator = controlsPage.GetComponent<Animator>();
        controlsButtonAnimator = controlsButton.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Mini_Game_1");
    }

    public void Controls()
    {
        controlsPageAnimator.SetTrigger("Enable");
    }

    public void ExitControls()
    {
        controlsButtonAnimator.SetTrigger("Normal");
        controlsPageAnimator.SetTrigger("Disable");
    }

    public void ButtonClicked()
    {
        animator.SetTrigger("Pressed");
    }
}
