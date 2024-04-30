using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIInGame : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score;

    public GameObject stopScene;

    public static UIInGame Instance;
    

    private void Awake()
    {
        Instance = this;
        
    }

    void Start()
    {
        score = 0;
        stopScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
    }

    public void ScoreUp()
    {
        score += 1;
    }

    public void UpdateScoreText()
    {
        scoreText.text = " " + score;
    }

    public void OnClickPause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;

        }
    }

    public void LoadSceneMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StopScene()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;

        }
        stopScene.SetActive(true);
    }
    public void NoButton()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;

        }
        stopScene.SetActive(false);
    }
    public void Restart()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;

        }
        score = 0;
        SceneManager.LoadScene("Game");
    }
}
