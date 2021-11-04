using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenFade : GameBehavior
{
    [SerializeField]
    private Image image;
    [SerializeField]
    private float duration;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            image.DOFade(1f, duration);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            image.DOFade(0f, duration);
        }
    }
}
