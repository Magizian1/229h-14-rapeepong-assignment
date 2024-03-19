using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float s_Time = 60f;
    private float timeUp;
    public TextMeshProUGUI timerText;

    
    

    
    // Update is called once per frame
    void Update()
    {
            timeUp = s_Time - Time.time;
            timerText.text = "Time : " + timeUp.ToString("F2");
            Debug.Log(timeUp);
    }

    
    
}
