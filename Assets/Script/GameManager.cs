using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;
/*using UnityEngine.UIElements;*/

public class GameManager : MonoBehaviour
{
    public float speedObstancle;

    public float   spawnTime;

    public int score;

    public bool isGameOver;

    public Button rePlayBtn;

    public GameObject overGamePanel;
    public GameObject inGamePanel;

    public TMP_Text currentScoreText;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;



    public static GameManager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        score = 0;
    }

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        rePlayBtn.onClick.RemoveAllListeners();


        rePlayBtn.onClick.AddListener(RePlay);


        currentScoreText.text = PlayerPrefs.GetInt("Score").ToString();

        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();

        scoreText.text = score.ToString();

        currentScoreText.text = PlayerPrefs.GetInt("Score").ToString();

    }
    private void Update()
    {
        ChangeSppedwithScore();
    }
    public void ChangeSppedwithScore()
    {
        if(score == 100)
        {
            speedObstancle = 4;
            spawnTime = 1.9f;
        }
        if (score == 200)
        {
            speedObstancle = 6;
            spawnTime = 1.2f;
        }
        if (score == 300)
        {
            speedObstancle = 8;
            spawnTime = 0.9f;
        }

    }
    public void RePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void AddScore()
    {
        score+=10;
        scoreText.text = score.ToString();

    }
    public void GameOver()
    {
        
        speedObstancle = 0;
        isGameOver = true;
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        PlayerPrefs.SetInt("Score", score);

        currentScoreText.text = PlayerPrefs.GetInt("Score").ToString();

        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();

        overGamePanel.SetActive(true);
        inGamePanel.SetActive(false);

    }
    
}
