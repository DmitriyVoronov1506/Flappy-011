using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFunctionsScript : MonoBehaviour
{
    private int score;

    public BirdScript bird;
    public GameObject startNewGame;
    public GameObject gameOver;

    [SerializeField]
    private TMPro.TextMeshProUGUI Clock;

    private void Start()
    {
        FirstStart();     
    }

    public int AddScores()
    {
        ++score;
        return score;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        startNewGame.SetActive(true);

        StopGame();
    }

    public void StartNewGame()
    {
        score = 0;
        Clock.text = "";

        gameOver.SetActive(false);
        startNewGame.SetActive(false);

        Time.timeScale = 1f;
        bird.enabled = true;

        bird.transform.position = new Vector3(-4.94f, 1.72f, 0);

        TubeScript[] pipes = FindObjectsOfType<TubeScript>();

        foreach(var p in pipes)
        {
            Destroy(p.gameObject);
        }
    }

    public void StopGame() 
    {
        Time.timeScale = 0f;
        bird.enabled = false;
    }

    public void FirstStart()
    {
        Application.targetFrameRate = 60;
        StopGame();
    }
}
