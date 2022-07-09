using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] Text ScoreText;
    [SerializeField] GameObject gameOver;

    static public bool playerAlive = false;
    float madePipe = 1.5f;
    float maxPipeHeight = 1f;
    float minPipeHeight = -1f;
    static public int score = 0;
    static public int Highscore = 0;
    static public int addSpeedCount = 0;

    private void Start()
    {
        GameStart();
    }
    public void GameStart()
    {
        playerAlive = true;
        score = 0;
        StartCoroutine(MovingPipe());
        
        gameOver.SetActive(false);
        
    }
    private void Update()
    {
        ScoreText.text = score.ToString();
    }
    IEnumerator MovingPipe()
    {
        while (true)
        {
            
            Instantiate(pipePrefab, new Vector3(10.0f, Random.Range(minPipeHeight, maxPipeHeight), 0), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(madePipe);
            
        }
        
    }
}
