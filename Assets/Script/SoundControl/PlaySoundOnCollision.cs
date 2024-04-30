using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    public static PlaySoundOnCollision Instance;

    private void Start()
    {
        Instance = this;
        audioClip = GetComponent<AudioClip>();  
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayS()
    {
        if (audioClip != null && audioSource != null) // ตรวจสอบว่า audioClip และ audioSource ไม่เป็น null ก่อนที่จะเล่นเสียง
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audio clip or audio source is null.");
        }
    }

}
