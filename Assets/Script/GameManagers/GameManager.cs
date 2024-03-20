using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float s_Time = 60f;
    private float timeUp;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timeEnd;
    public TextMeshProUGUI scoreEnd;

    public GameObject uiScene;
    public GameObject endScene;



    private void Start()
    {
        uiScene.SetActive(true);
        endScene.SetActive(false);
    }


    void Update()
    {
            timeUp = s_Time - Time.time;
            timerText.text = "Time : " + timeUp.ToString("F2");
            Debug.Log(timeUp);
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

    public void OnPause()
    {
        Debug.Log("GameManager OnPause() is called.");

        
        Time.timeScale = 0;
        
        
        ShowSumUi();
    }

    public void ShowSumUi()
    {
        timeEnd.text = "Time : " + timerText;
        scoreEnd.text = "Score : " + BubbleCoin.Instance.bubleWalletText;
        uiScene.SetActive(false);
        endScene.SetActive(true);
    }
}
