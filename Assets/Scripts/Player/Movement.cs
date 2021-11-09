using System;
using UnityEngine;
public class Movement : GameBehavior
{
    public float speed = 3.0F;
    [SerializeField] private Transform _transform;
    [SerializeField] private Animator _animator;
    private SpriteRenderer _renderer;

    private void Start()
    {
        Physics.gravity = new Vector2(0, 0);
        _animator = gameObject.GetComponent<Animator>();
        _renderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        // get player movement from a, d
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        // always multi by Time.deltaTime
        transform.position += move * speed * Time.deltaTime;

        if (move.x < 0)
        {
            _transform.localScale = new Vector3(-0.2f, 0.2f, 1f);
            _animator.SetBool("IsWalking", true);            
        }
        else if (move.x > 0)
        {
            _transform.localScale =  new Vector3(0.2f, 0.2f, 1f);
            _animator.SetBool("IsWalking", true);
        }else
        {
            _animator.SetBool("IsWalking", false);
        }
    }

    private Vector3 OnLadder()
    {
        return new Vector3(0, Input.GetAxis("Vertical"), 0);
    }
}
