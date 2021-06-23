using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaidScript : MonoBehaviour
{
    public MainScript Consumables;
    public TimerSimple EnemyTimer;
    public int Vave;
    public bool counter;

    
    void Start()
    {
        Vave = 1;
        counter = true;
    }

    private void Update()
    {
        //if (counter == true)
        //{
        //    if (EnemyTimer.TimerCurrentTime <= 0.01)
        //    {
        //        Consumables.Warriors -= Consumables.Enemy;
        //        Vave += 1;
        //        counter = false;
        //    }
        //}

    }

    
    public void GetEnemy()
    {
            if (Vave <= 3)
            {
            counter = true;
        }
            if (Vave == 3)
            {
                Consumables.Enemy = Random.Range(5, 10);
            counter = true;
        }
            if ( Vave >= 4 & Vave <= 6 )
            {
                Consumables.Enemy = Random.Range(7, 12);
            counter = true;
        }
            if (Vave > 6)
            {
                Consumables.Enemy = Random.Range(12, 23);
            counter = true;
        }
    }
}
