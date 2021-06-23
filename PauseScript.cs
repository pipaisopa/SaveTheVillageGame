using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool GameisPaused = false;
    [SerializeField] private GameObject PausePanel;

    public void PauseGame()
    {
        if (GameisPaused)
        {
            Resume();
            GameisPaused = false;
        }
        else
        {
            Pause();
            GameisPaused = true;
        }
    }


    void Resume()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }

     void Pause()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
    }
}
