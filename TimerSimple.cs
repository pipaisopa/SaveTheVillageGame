using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSimple : MonoBehaviour
{
    public float TimerMaxTime;
    public Image TimerImg;
    public float TimerCurrentTime;
    public AudioSource Audio;
    [SerializeField] private MainScript Consumables;
    [SerializeField] private RaidScript EnemyRaid;
    [SerializeField] private bool FoodBool;
    [SerializeField] private bool EatBool;
    [SerializeField] private bool RaidBool;



    private void Start()
    {
        TimerCurrentTime = TimerMaxTime;
        Audio = GetComponent<AudioSource>();

    }

    public void Update()
    {
    TimerCurrentTime -= Time.deltaTime;

        if (FoodBool == true)
        {
            if (TimerCurrentTime <= 0)
            {
                Consumables.Food = Consumables.Food + (Consumables.Workers * 2);
                TimerCurrentTime = TimerMaxTime;
                Audio.Play();
                
            }
            TimerImg.fillAmount = TimerCurrentTime / TimerMaxTime;
        }
        if (EatBool == true)
        {
            if (TimerCurrentTime <= 0)
            {
                Consumables.Food = Consumables.Food - (Consumables.Warriors * 4);
                TimerCurrentTime = TimerMaxTime;
                if (Consumables.Warriors != 0)
                {
                    Audio.Play();

                }

            }
            TimerImg.fillAmount = TimerCurrentTime / TimerMaxTime;
        }
        if (RaidBool == true )
        {
            
            if (TimerCurrentTime <= 0)
            {
                
                Debug.Log(Consumables.Enemy);
                if (Consumables.Warriors != 0 & EnemyRaid.Vave >= 3)
                {
                    Audio.Play();
                }
                EnemyRaid.Vave += 1;
                Consumables.Warriors -= Consumables.Enemy;
                TimerCurrentTime = TimerMaxTime;
            }
            TimerImg.fillAmount = TimerCurrentTime / TimerMaxTime;
        }
        //else
        //{
        //    if (TimerCurrentTime <= 0)
        //    {
        //        TimerCurrentTime = TimerMaxTime;
        //        Audio.Play();
                
        //    }
        //    TimerImg.fillAmount = TimerCurrentTime / TimerMaxTime;
        //}
        
       
    }
}
