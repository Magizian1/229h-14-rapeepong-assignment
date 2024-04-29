using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        SetCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void SetCoins()
    {
        foreach (GameObject spawnPoint in spawnPoints)
        {
            Instantiate(coinPrefab, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
