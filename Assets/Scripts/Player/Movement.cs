using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player { };
public class Movement : GameBehavior
{
    private CharacterController _controller;
    public float speed = 3.0F;
    
    private void Start()
    {
        // useful if we add physics but idk
        _controller = gameObject.AddComponent<CharacterController>();
    }
    
    private void Update()
    {
        // get player movement from a, d
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
        // always multi by Time.deltaTime
        transform.position += move * speed * Time.deltaTime;
    }
}
