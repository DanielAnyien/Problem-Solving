using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null) _instance = FindObjectOfType<GameManager>();
            return _instance;
        }
    }

    private int score;
    [SerializeField] private Text scoreText;
    [SerializeField] ObjSpawn spawner;

    [Header("UI")]
    public UIGameOver GameOverUI;
    public bool IsGameOver { get { return isGameOver; } }

    private bool isGameOver = false;

    void Start ()
    {
        scoreText.text = "Score : " + score;
    }

    public void AddScore (int addScore)
    {
        score += addScore;
        scoreText.text = "Score : " + score;
    }

    public void AddScore (int addScore, GameObject square)
    {
        score += addScore;
        scoreText.text = "Score : " + score;
        spawner.Respawn(square);
    }

    public void GameOver()
    {
        isGameOver = true;
        GameOverUI.Show();
    }
}
