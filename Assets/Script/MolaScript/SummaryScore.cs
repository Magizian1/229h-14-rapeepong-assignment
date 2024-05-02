using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SummaryScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textSum;
    private int textScore;

    // Start is called before the first frame update
    void Start()
    {
        textScore = UIInGame.Instance.score;
    }

    // Update is called once per frame
    void Update()
    {
        textSum.text = "Score : " + textScore.ToString();
    }
}
