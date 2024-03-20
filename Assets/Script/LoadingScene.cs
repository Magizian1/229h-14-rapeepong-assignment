using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public GameObject howToScene;

    private void Start()
    {
        howToScene.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnClickHowto()
    {
        howToScene.SetActive(true);
    }
    public void ClickOutHowto()
    {
        howToScene.SetActive(false);
    }
}
