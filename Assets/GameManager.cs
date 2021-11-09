using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GameBehavior
{
    private GameObject _player;
    
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    
    /// <summary>
    ///     Gets the Player GameObject
    /// </summary>
    /// <returns>GameObject</returns>
    public GameObject GetPlayer()
    {
        return _player;
    }
}
