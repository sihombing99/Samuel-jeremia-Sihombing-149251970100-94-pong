using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skor : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public BallControl ball;
    public int menang;

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();
        if (rightScore >= menang)
        {
            GameOver();
        }
    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();
        if (leftScore >= menang)
        {
            GameOver(); 
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("UI");
    }
}
