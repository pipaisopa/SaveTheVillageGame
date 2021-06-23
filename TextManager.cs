using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    [SerializeField] Text FoodText;
    [SerializeField] Text WorkersText;
    [SerializeField] Text WarriorsText;
    [SerializeField] Text TextRaid;
    [SerializeField] Text YouWinText;
    [SerializeField] Text YouLoseText;
    [SerializeField] Text VaveText;

    public MainScript Consumables;
    public TimerSimple EnemyTimer; 
    [SerializeField] RaidScript Raid;
    private int counter;
    private void Start()
    {
        counter = 0;      
    }


    void Update()
    {
        FoodText.text = $"Пшеницы: {Consumables.Food}";
        WorkersText.text = $"Крестьян: {Consumables.Workers}";
        WarriorsText.text = $"Воинов: {Consumables.Warriors}";
        VaveText.text = $"Волна: {Raid.Vave}";
        if (EnemyTimer.TimerCurrentTime <= 10 & counter == 0)
        {
            Raid.GetEnemy();
            TextRaid.text = $"В следую щей волне будет {Consumables.Enemy} варваров";
            counter = 1;
            YouWinText.text = $"Вы победили! Вы пережили {Raid.Vave} волн, содержали {Consumables.Workers} крестьян и {Consumables.Warriors} воинов, в амбаре осталось {Consumables.Food} пшеницы";
            YouLoseText.text = $"Вы проиграли! Вы пережили {Raid.Vave - 1} волн, содержали {Consumables.Workers} крестьян и {Consumables.Warriors} воинов, а в амбаре осталось {Consumables.Food} пшеницы";
        }
        if (EnemyTimer.TimerCurrentTime > 10 & counter == 1)
        {
            
            TextRaid.text = " ";
            counter = 0;
        }
    }
}
