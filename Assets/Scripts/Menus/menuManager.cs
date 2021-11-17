using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField] private GameObject _TitleScreen;
    [SerializeField] protected GameObject _OptionsMenu;
    
    
    //Options Menu Variables
    [SerializeField] protected GameObject _Volume;
    [SerializeField] protected GameObject _TextSpeed;
    [SerializeField] protected GameObject _Music;
    protected float Volume ;
    protected float Music;
    protected float TextSpeed;
    
    



    //Options Menu Methods
    public void OverallVolume()
    {
        
    }public void SFXVolume()
    {
        
    }public void MusicVolume()
    {
        
    }

    //Title Screen Methods
    public void LoadGame()
    {
        SceneManager.LoadScene("TestScene1");
        Time.timeScale = 1f;
    }public void NewGame()
    {

    }public void QuitGame()
    {

    }
    //Pause Screen Methods
    
    //Extra Methods
    void Start() 
    {
        _TitleScreen.SetActive(true);
        _OptionsMenu.SetActive(false);
    }
    public void SaveGame()
    {
        
    }
    void Update() 
    {
        Music = _Music.GetComponent<Slider>().value;
        TextSpeed = _TextSpeed.GetComponent<Slider>().value;
        Volume = _Volume.GetComponent<Slider>().value;
        Debug.Log(Music);
    }
    
}
