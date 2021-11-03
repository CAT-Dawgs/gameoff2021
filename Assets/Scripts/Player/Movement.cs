using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player { };
public class Movement : MonoBehaviour
{
    private CharacterController _controller;
    public float speed = 3.0F;
    // Start is called before the first frame update
    void Start()
    {
        _controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // get player movement from a, d
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
        // always multi by Time.deltaTime
        transform.position += move * speed * Time.deltaTime;
    }
}
