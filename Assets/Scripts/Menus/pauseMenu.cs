using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : menuManager
{
   [SerializeField] private GameObject _PauseMenu;
   public static bool GameIsPaused = false;
   public void QuitFromPause()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ContinueFromPause()
    {
        Resume();
    }void Update() 
    {
        Music = _Music.GetComponent<Slider>().value;
        TextSpeed = _TextSpeed.GetComponent<Slider>().value;
        Volume = _Volume.GetComponent<Slider>().value;
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }public void Resume()
    {
        _PauseMenu.SetActive(false);
        _OptionsMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        _PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;     
    }
    void Start() 
    {
        _PauseMenu.SetActive(false);
        _OptionsMenu.SetActive(false);
    }
}
