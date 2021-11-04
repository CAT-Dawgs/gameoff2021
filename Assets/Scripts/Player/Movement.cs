using UnityEngine;
public class Movement : GameBehavior
{
    public float speed = 3.0F;
    
    private void Update()
    {
        // get player movement from a, d
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
        // always multi by Time.deltaTime
        transform.position += move * speed * Time.deltaTime;
    }
}
