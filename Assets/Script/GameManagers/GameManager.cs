using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float s_Time = 60f;
    

    private float timeElapsed;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timeEnd;
    

    public GameObject uiScene;
    public GameObject endScene;
    public GameObject credit;

    

    

    
    private void Start()
    {
        
        uiScene.SetActive(true);
        endScene.SetActive(false);
        credit.SetActive(false);

        timeElapsed = 0f;
        
    }


    void Update()
    {
        timeElapsed += Time.deltaTime; 
        float timeRemaining = s_Time - timeElapsed;
        


        if (timeRemaining <= 0)
        {
            EndGame();
        }

        timerText.text = "Time : " + timeRemaining.ToString("F2");
        timeEnd.text = "Time : " + timeRemaining.ToString("F2");
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

    public void Restart(string sceneName)
    {
        timeElapsed = 0f;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  

    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        uiScene.SetActive(false);
        endScene.SetActive(true);
        
    }
    public void OnClickCredit()
    {
        credit.SetActive(true);
    }
    public void ClickOutCredit()
    {
        credit.SetActive(false);
    }

    
}
