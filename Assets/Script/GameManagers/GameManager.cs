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
            timeEnd.text = "Time : " + timeUp.ToString("F2");
            
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
}
