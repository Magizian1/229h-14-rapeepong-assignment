using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BubbleCoin : MonoBehaviour
{
    public static BubbleCoin Instance;

    private int bubble = 0;

    public TextMeshProUGUI bubleWalletText;

    private void OnTriggerEnter(Collider u)
    {
        if (u.transform.tag == "Bubble")
        {
            bubble++;
            bubleWalletText.text = "Score :" + bubble.ToString();
            Debug.Log(bubble);
            Destroy(u.gameObject);
            
        }
        if (u.transform.tag == "Goal")
        {
            GameManager.Instance.OnPause();
            //GameManager.Instance.ShowSumUi();
            //endScene.SetActive(true);
        }
    }
    
}
