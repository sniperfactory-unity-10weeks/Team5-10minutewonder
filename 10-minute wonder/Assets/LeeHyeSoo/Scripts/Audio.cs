using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip bgmAudioClip;
    public AudioClip clikAuidioClip;
    AudioSource audioSource;

    private static Audio instance = null;

    private void Awake()
    {
        if(null ==instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = bgmAudioClip;
        audioSource.Play();



    }
}
