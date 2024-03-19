using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DonDestroy : MonoBehaviour
{
    

    

    void Start()
    {
        
        DontDestroyOnLoad(gameObject);
        
    }
    

}
