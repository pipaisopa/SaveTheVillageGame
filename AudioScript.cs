using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        Audio.Play();
    }
}
