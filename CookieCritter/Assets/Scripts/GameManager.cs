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
    // Start is called before the first frame update
    void Start()
    {
        OverallScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
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

}