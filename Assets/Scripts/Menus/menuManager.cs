using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField] private GameObject _TitleScreen;
    [SerializeField] private GameObject _OptionsMenu;
    [SerializeField] private GameObject _PauseMenu;
    //Currently when you select quit from the options menu after selecting it 
    //from the pause menu it takes you back to title screen
    //Options Menu Variables
    [SerializeField] private GameObject _Volume;
    [SerializeField] private GameObject _SFX;
    [SerializeField] private GameObject _Music;
    private float Volume;
    private float Music;
    private float SFX;
    //Title Screen Variables



    //Options Menu Methods
    public void OverallVolume()
    {
        Volume = _Volume.GetComponent<Slider>().value;
    }public void SFXVolume()
    {
        SFX = _SFX.GetComponent<Slider>().value;
    }public void MusicVolume()
    {
        Music = _Music.GetComponent<Slider>().value;
    }

    //Title Screen Methods
    public void LoadGame()
    {
        SceneManager.LoadScene("TestScene1");
    }public void NewGame()
    {

    }public void QuitGame()
    {

    }
    //Pause Screen Methods
    public void QuitFromPause()
    {

    }public void ContinueFromPause()
    {

    }
    //Extra Methods
    void Start() 
    {
        _TitleScreen.SetActive(true);
        _OptionsMenu.SetActive(false);
        _PauseMenu.SetActive(false);
    }

}
