using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInGame : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score;
    public static UIInGame Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        score = 0;
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
}
