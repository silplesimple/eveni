using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip bgmclip;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        GetBGM();
    }

    public void GetBGM()
    {
        audioSource.clip = bgmclip;
        audioSource.Stop();
        audioSource.Play();
    }
}
