using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    private int goalScore = 2000;

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void SetCurrentScore(int newScore)
    {
        currentScore += newScore;
        Debug.Log(currentScore);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("CurrentScore", currentScore);

        if(currentScore > PlayerPrefs.GetInt("highscore"))
        {
            Debug.Log("new highscore");
            PlayerPrefs.SetInt("highscore", currentScore);
        }

        if(currentScore > goalScore) 
        {
            SceneManager.LoadScene(2);
        }
    }
}
