using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame = false;
    public GameObject PauseGameMenu;
    public GameObject GameUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseGameMenu.SetActive(false);
        GameUI.SetActive(true);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        PauseGameMenu.SetActive(true);
        GameUI.SetActive(false);
        Time.timeScale = 0f;
        PauseGame = true;
    }

}
