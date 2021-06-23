using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MutedScript : MonoBehaviour
{
    public AudioListener Listener;
    private bool toggle;
    [SerializeField] private Image MuteImg;
    [SerializeField] private Sprite MutedImg;
    [SerializeField] private Sprite NotMutedImg;

    private void Start()
    {
        Listener = GetComponent<AudioListener>();
    }

    public void Mute()
    {
        toggle = !toggle;

        if (toggle)
        {
            AudioListener.volume = 0f;
            MuteImg.sprite = NotMutedImg;
        }
        else
        {
            AudioListener.volume = 1f;
            MuteImg.sprite = MutedImg;
        }
            

    }
}
