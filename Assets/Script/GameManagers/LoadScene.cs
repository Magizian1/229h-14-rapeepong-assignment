using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] public string scene1;
    [SerializeField] public string scene2;
    [SerializeField] public string scene3;

    [SerializeField] public GameObject gameScene1;
    // Start is called before the first frame update
    void Start()
    {
        gameScene1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene(scene1);
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene(scene2);
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene(scene3);
    }
    public void CreditScene()
    {
        gameScene1.SetActive(true);
    }
    public void CloseCreditScene()
    {
        gameScene1.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
