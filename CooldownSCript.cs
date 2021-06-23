using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownSCript : MonoBehaviour
{
    public float TimerMaxTime;
    public Image TimerImg;
    public GameObject CooldownTimer;
    public float TimerCurrentTime;
    public Button GetUnitButton;
    private int counter = 0;
    public MainScript Consumables;
    public int Limit;

    private void Start()
    {

        CooldownTimer.SetActive(false);
    }


    private void Update()
    {

       
        
        if (counter == 0)
        {
            if (Consumables.Food < Limit)
            {
                GetUnitButton.interactable = false;
                
            }
            else
            {
                GetUnitButton.interactable = true;
               
            }

        }

        if (counter == 1)
        {
            
            TimerCurrentTime -= Time.deltaTime;
            if (TimerCurrentTime <= 0)
            {
                
                GetUnitButton.interactable = true;
                
                counter = 0;
                CooldownTimer.SetActive(false);
            }
            TimerImg.fillAmount = TimerCurrentTime / TimerMaxTime;
            
        }
        
    }

    
        


    public void Cooldown()
    {
        Debug.Log("Должна стать неактивной");
        GetUnitButton.interactable = false;
        counter = 1;
        TimerCurrentTime = TimerMaxTime;
        CooldownTimer.SetActive(true);
    }
   

    
   
}
