using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float startSpeed = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 
        rb2d.linearVelocity = Vector2.up * startSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb2d.linearVelocity = rb2d.linearVelocity.normalized * startSpeed;
    }
}
