using UnityEngine;

public class GameManager : GameBehavior
{
    private GameObject _player;
    private bool _isPaused;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _isPaused = false;
    }

    /// <summary>
    ///     Gets the Player GameObject
    /// </summary>
    /// <returns>GameObject</returns>
    public GameObject GetPlayer()
    {
        return _player;
    }

    public bool GetPaused()
    {
        return _isPaused;
    }
    
}
