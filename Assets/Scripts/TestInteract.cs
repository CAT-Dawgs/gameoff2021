using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract : GameBehavior, IInteractable
{
    [SerializeField] [Range(0.01F, 10F)]
    private float distance = 0.5F;
    private Transform _player;
    void Start()
    {
        _player = GameManager.GetPlayer().transform;
    }

    void Update()
    {
        var playerDistance = Vector3.Distance(_player.position, this.gameObject.transform.position);
        
        if (distance >= playerDistance)
        {
            OnStartInteract();
        }
    }

    public void OnStartInteract()
    {
        Input.GetAxis("Vertical");
    }

    public void OnEndInteract()
    {
        Debug.Log("Lol it finished running");
    }
}
