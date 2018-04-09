﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour {

    public GameObject balls;
    public GameObject startButton;

    public float timeBetweenSpawns;
    public GameObject endGameScreen;
    public Text scoreText;

    public float timer;
    private int score = 0;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (timer <= 0)
        {
            timer = timeBetweenSpawns;
           Instantiate(balls, Vector3.right * (int)Random.Range(0, 10), Quaternion.identity);
        }
        timer -= Time.deltaTime;
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        endGameScreen.SetActive(true);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Wynik:" + score;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}


    

    


