using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera
{
    // this was made to stop IDE from erroring
}
public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // empty cuz we dont need it lol
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            player.position.x + offset.x, 
            player.position.y + offset.y, 
            player.position.z + offset.z);
    }
}
