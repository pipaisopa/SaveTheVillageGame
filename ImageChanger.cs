using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Sprite NewSprite;
    private Image img;
    private AudioSource Audio;
    private AudioClip Clip;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        Audio = GetComponent<AudioSource>();
        Audio.Play();
    }

    public void ChangeSprite()
    {
        img.sprite = NewSprite;
        img.SetNativeSize();
    }

    public void ChangeColor()
    {
        img.color = Color.magenta;
        
    }


    public void ChangAudioPlay()
    {
        if (Audio.isPlaying)
        {
            Audio.Pause();
        }
        else
        {
            Audio.Play();
        }
    
    }

    public void ChangeSound()
    {
        Audio.clip = Clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
