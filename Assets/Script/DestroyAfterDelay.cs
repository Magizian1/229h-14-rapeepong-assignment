using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    private float timer = 0f;
    private float delay = 5f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            Destroy(gameObject);
        }
    }
}
