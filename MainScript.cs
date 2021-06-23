using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    
    public int Food;
    public int Workers;
    public int Warriors;
    public int Enemy;
    [SerializeField] TimerSimple FoodTimer;
    [SerializeField] TimerSimple EatTimer;



    
    private int WorkerTimer;
    private int WarriorTimer;

    private void Start()
    {
        Workers = 1;
        Food = 0;
        Warriors = 0;
    }





   
        




    public void GetWarrior()
    {
        if (Food < 5)
        {
            Warriors += 0;
        }
        else
        {
           
            Warriors += 1;
            Food -= 5;
           
        }
        
    }

    public void GetWorker()
    {
        if (Food < 3)
        {
            Workers += 0;
        }
        else
        {
            Workers += 1;
            Food -= 3;
           
        }
       
    }
   

   
}
