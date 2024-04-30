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
        if (audioClip != null && audioSource != null) // ��Ǩ�ͺ��� audioClip ��� audioSource ����� null ��͹����������§
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
