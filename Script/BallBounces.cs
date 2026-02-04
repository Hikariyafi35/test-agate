using UnityEngine;

public class BallBounces : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 lastVelocity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        lastVelocity = rb.linearVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector2.Reflect(lastVelocity.normalized, collision2D.contacts[0].normal);

        rb.linearVelocity = direction * Mathf.Max(speed, 0);
    }
}
