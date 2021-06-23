using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject YouLosePanel;
    public GameObject GamePanel;
    public GameObject YouWinPanel;
    public GameObject RaidText;
    public MainScript Consumables;

    
    void Start()
    {
        GamePanel.SetActive(true);
    }

    public void Update()
    {
        if (Consumables.Food < 0 || Consumables.Warriors < 0)
        {
            GamePanel.SetActive(false);
            YouLosePanel.SetActive(true);
        }
        if (Consumables.Warriors >= 30 & Consumables.Workers >= 30)
        {
            GamePanel.SetActive(false);
            YouWinPanel.SetActive(true);
        }

    }

}
