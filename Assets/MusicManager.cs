using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///     Global audio object, use for soundtracks and stuff.
/// </summary>
public class MusicManager : MonoBehaviour
{
    private AudioSource _audioSource;
    
    private void Start()
    {
        _audioSource = gameObject.AddComponent<AudioSource>();
    }

    public AudioSource GetAudioSource()
    {
        return _audioSource;
    }

    public void SetAudioClip(AudioClip audioClip)
    {
        _audioSource.clip = audioClip;
    }
}
