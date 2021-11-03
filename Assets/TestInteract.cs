using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract : MonoBehaviour, IInteractable
{
    [SerializeField] [Range(0.01F, 10F)]
    private float distance = 0.5F;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update()
    {
        var playerDistance = Vector3.Distance(player.position, this.gameObject.transform.position);
        Debug.Log(playerDistance);
        if (player != null && distance >= playerDistance)
        {
            OnStartInteract();
        }
    }

    public void OnStartInteract()
    {
        Debug.Log("Lol it ran");
    }

    public void OnEndInteract()
    {
        Debug.Log("Lol it finished running");
    }
}
