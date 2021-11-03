using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Camera
{
    // this was made to stop IDE from erroring
}
public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;
    [SerializeField] [Range(0.1f, 0.5f)] 
    private float smoothSpeed;
    private Vector3 velocity = Vector3.zero;
    
    private void LateUpdate()
    {
        var desPos = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desPos, ref velocity, smoothSpeed);
    }
}
