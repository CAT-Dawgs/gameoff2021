using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private GameObject pauseMenu;
    //Currently when you select quit from the options menu after selecting it 
    //from the pause menu it takes you back to title screen
    //Options Menu Variables
    [SerializeField] private GameObject volume;
    [SerializeField] private GameObject sfx;
    [SerializeField] private GameObject music;
    private float _volume;
    private float _music;
    private float _sfx;
    //Title Screen Variables



    //Options Menu Methods
    public void OverallVolume()
    {
        _volume = volume.GetComponent<Slider>().value;
    }
    public void SFXVolume()
    {
        _sfx = sfx.GetComponent<Slider>().value;
    }
    public void MusicVolume()
    {
        _music = music.GetComponent<Slider>().value;
    }

    //Title Screen Methods
    public void LoadGame()
    {
        SceneManager.LoadScene("TestScene1");
    }
    public void NewGame()
    {

    }
    public void QuitGame()
    {

    }
    //Pause Screen Methods
    public void QuitFromPause()
    {

    }
    public void ContinueFromPause()
    {

    }
    //Extra Methods
    void Start() 
    {
        titleScreen.SetActive(true);
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(false);
    }

}
