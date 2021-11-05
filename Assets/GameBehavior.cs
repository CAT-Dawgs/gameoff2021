using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///     A MonoBehavior that has caches of the important managers used in the game
/// </summary>
public class GameBehavior : MonoBehaviour {
    
    // gets the game manager
    protected CachedComponent<GameManager> _gameManager = new CachedComponent<GameManager>();
    protected GameManager GameManager => _gameManager.Instance(this);
    
    protected CachedComponent<MusicManager> _musicManager = new CachedComponent<MusicManager>();
    protected MusicManager MusicManager => _musicManager.Instance(this);

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        _gameManager.Clear();
        _musicManager.Clear();
    }
}
