using UnityEngine;

namespace Camera
{
    // this was made to stop IDE from erroring
}
public class FollowPlayer : GameBehavior
{
    [SerializeField] private Vector3 offset;
    [SerializeField] [Range(0.1f, 0.5f)] 
    private float smoothSpeed;
    private Vector3 _velocity = Vector3.zero;
    private GameObject _player;

    private void Start()
    {
        _player = GameManager.GetPlayer();
    }
    
    private void LateUpdate()
    {
        var desPos = _player.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desPos, ref _velocity, smoothSpeed);
    }
}
