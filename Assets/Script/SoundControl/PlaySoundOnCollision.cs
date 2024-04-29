using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource; // ��˹� AudioSource � Inspector

    public static PlaySoundOnCollision Instance;


    private void Start()
    {
        Instance = this;
        audioClip = GetComponent<AudioClip>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player")) // ��� Tag �ͧ Player �������������
        {
            
            audioSource.Play();
        }
    }
}
