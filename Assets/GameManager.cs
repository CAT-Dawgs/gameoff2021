using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

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

    public void FadeOut(Image img, float duration)
    {
        img.DOFade(0f, duration);
    }

    public void FadeIn()
    {
        
    }
    
}
