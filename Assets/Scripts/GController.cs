﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GController : MonoBehaviour {
    [SerializeField]
    private GameObject[] hazards;
    [SerializeField]
    private Vector3 spawnValues;
    [SerializeField]
    private int hazardCount;
    [SerializeField]
    private float spawnWait;
    [SerializeField]
    private float startWait;
    [SerializeField]
    private float waveWait;
   
    private int score;
    private Text scoreText; 
    private Text restartText; 
    private Text gameOverText;
    private bool gameOver;
    private bool restart;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        restart = false;
        score = 0;
        scoreText = GameObject.Find("Canvas/ScoreText").GetComponent<Text>();
        gameOverText = GameObject.Find("Canvas/GameOverText").GetComponent<Text>();
        restartText = GameObject.Find("Canvas/RestartText").GetComponent<Text>();
        restartText.text = "";
        gameOverText.text = "";
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (!gameOver) {
            for (int i = 0; i < hazardCount; i++) {
                GameObject hazard = hazards[Random.Range(0,hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity; //no rotation
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
        restartText.text = "Press 'R' to Restart";
        restart = true;
    }
	
	
    public void AddScore(int newScoreValue)
    {
        if (score + newScoreValue <= 0)
        {
            score = 0;
        }
        else
        {
            score += newScoreValue;
        }
        UpdateScore();
    }

    public void GameOver(float myFloat)
    {
        Debug.Log(myFloat);
        gameOverText.text = "Game Over";
        gameOver = true;
    }

	void UpdateScore () {
        if (!gameOver)
        {
            scoreText.text = "Score : " + score;
        }
	}

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void Test()
    {
        Debug.Log("Test");
    }
}
