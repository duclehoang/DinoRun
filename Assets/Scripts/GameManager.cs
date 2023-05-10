using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance
    public GameObject obstanSpawn;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public GameObject PauseGameGUI;
    public GameObject buttonPauseGameGUI;

    private AudioSundEffect audioEffect;
    private TextureScroll[] scrollingObjects;
    private GameObject[] obstacleObjects;
    private bool isGamePause = false;
    private int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        audioEffect = FindObjectOfType<AudioSundEffect>();
        scrollingObjects = FindObjectsOfType<TextureScroll>();
        obstacleObjects = GameObject.FindGameObjectsWithTag("obstacle");
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }

    public void GameOver()
    {
        audioEffect.musicDead();
        StopScroll();
        stopObstacle();
        obstanSpawn.SetActive(false);
        score = 0;
        scoreText.gameObject.SetActive(false);
        gameOverPanel.SetActive(true);
        buttonPauseGameGUI.SetActive(false);
    }

    private void StopScroll()
    {
        foreach (TextureScroll t in scrollingObjects)
        {
            t.scroll = false;
        }
    }

    private void stopObstacle()
    {
        foreach (GameObject t in obstacleObjects)
        {
            t.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    public void PauseGame()
    {
        PauseGameGUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePause = true;
        buttonPauseGameGUI.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isGamePause = false;
        PauseGameGUI.SetActive(false);
        buttonPauseGameGUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("game");
    }

    public void GameMenu()
    {
        SceneManager.LoadScene("Menu");
    }

     public void QuitGame()
    {
       Application.Quit();
    }
}
