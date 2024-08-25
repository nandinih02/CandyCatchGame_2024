using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;
    int lives = 3;
    bool gameOver = false;
    public GameObject gameOverPanel;


    public GameObject livesHolder;

    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            print(score);
        }
        
    }

    public void DecreaseLife()
    {
        if(lives>0)
        {
            lives--;
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);

        }

        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
        
    }

    private void GameOver()
    {
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
        print("Game Over");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
