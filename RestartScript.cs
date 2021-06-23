using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
     [SerializeField] private TimerSimple TimerFood;
    [SerializeField] private TimerSimple TimerEat;
    [SerializeField] private TimerSimple TimerEnemy;
    [SerializeField] private MainScript Consumables;
    [SerializeField] private PanelManager Panels;
    [SerializeField] private RaidScript Raid;



    public void RestartGame()
    {
        TimerFood.TimerCurrentTime = TimerFood.TimerMaxTime;
        TimerEat.TimerCurrentTime = TimerEat.TimerMaxTime;
        TimerEnemy.TimerCurrentTime = TimerEnemy.TimerMaxTime;
        Consumables.Food = 0;
        Consumables.Workers = 1;
        Consumables.Warriors = 0;
        Consumables.Enemy = 0;
        Panels.YouWinPanel.SetActive(false);
        Panels.YouLosePanel.SetActive(false);
        Panels.GamePanel.SetActive(true);
        Raid.Vave = 0;

    }
}
