using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private AudioSource _audioSource;
    void Start()
    {
        _audioSource = gameObject.AddComponent<AudioSource>();
    }

    public AudioSource GetAudioSource()
    {
        return _audioSource;
    }
}
