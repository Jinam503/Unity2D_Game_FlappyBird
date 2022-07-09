using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] Text Score;
    [SerializeField] Text highScore;

    private void OnEnable()
    {
        string a = "Score: " + GameManager.score.ToString();
        Score.text = a;
        if (GameManager.Highscore< GameManager.score)
        {
            GameManager.Highscore = GameManager.score;
        }
        string b = "HighScore: " + GameManager.Highscore.ToString();
        highScore.text = b;
    }
    public void ReStart()
    {
        GameManager.score = 0;
        SceneManager.LoadScene("SampleScene");
        
    }
}
