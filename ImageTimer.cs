using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTimer : MonoBehaviour
{
    public float MaxTime;
    private Image img;
    public float CurrentTime;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        CurrentTime = MaxTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        {
            CurrentTime = MaxTime;
        }
        img.fillAmount = CurrentTime / MaxTime;
    }
}
