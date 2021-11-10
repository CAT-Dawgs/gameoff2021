using System;
using UnityEngine;
public class Movement : GameBehavior
{
    public float speed = 3.0F;
    public Rigidbody2D rb;
    private Transform _transform;
    private Animator _animator;
    private SpriteRenderer _renderer;

    public float jumpForce = 20f;

    private void Start()
    {
        Physics.gravity = new Vector2(0, 0);
        _animator = gameObject.GetComponent<Animator>();
        _renderer = gameObject.GetComponent<SpriteRenderer>();
        _transform = gameObject.GetComponent<Transform>();
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

        //jump key is spacebar
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private Vector3 OnLadder()
    {
        return new Vector3(0, Input.GetAxis("Vertical"), 0);
    }

    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }
}
