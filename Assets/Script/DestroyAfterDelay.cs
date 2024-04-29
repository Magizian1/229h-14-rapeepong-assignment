using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    private float timer = 0f;
    private float delay = 5f;

    public AudioClip clip;
    public AudioSource source;

    public GameObject particlePrefab;

    private void Start()
    {
        clip = GetComponent<AudioClip>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            source.Play();
            Destroy(collision.gameObject);
            UIInGame.Instance.ScoreUp();
            OnDestroy();
        }
    }
    void OnDestroy()
    {
        if (particlePrefab != null)
        {
            Instantiate(particlePrefab, transform.position, Quaternion.identity);
            timer += Time.deltaTime;

            if (timer >= delay)
            {
                Destroy(particlePrefab);
            }
        }
    }
}
