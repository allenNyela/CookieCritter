using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public static float CurrentScore;
    [SerializeField]
    public static float OverallScore;
    //how many flour it's eaten
    public static int OverallFlourCount;
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        OverallScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Debug.Log("p was pressed");
            if (isPaused)
            {
                isPaused = false;
            } else
            {
                isPaused = true;
            }        
        }
    }


    public static void IncreaseScore()
    {
        CurrentScore++;
    }

    public static void AddToOverallScore(float score)
    {
        OverallScore += score;
    }

    public static void DecreaseFromOverallScore(float score)
    {
        OverallScore -= score;
    }

    public static float GetCurrentScore()
    {
        return CurrentScore;
    }

    public static float GetOverallScore()
    {
        return OverallScore;
    }

    public static void ResetCurrentScore()
    {
        CurrentScore = 0;
    }

    public static bool IsPaused()
    {
        return isPaused;
    }

}
