using UnityEngine;
public class Movement : GameBehavior
{
    public float speed = 3.0F;

    private void Start()
    {
        Physics.gravity = new Vector2(0, 0);
    }
    private void Update()
    {
        // get player movement from a, d
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        // always multi by Time.deltaTime
        transform.position += move * speed * Time.deltaTime;
    }

    private Vector3 OnLadder()
    {
        return new Vector3(0, Input.GetAxis("Vertical"), 0);
    }
}
