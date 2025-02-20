using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class BallController : MonoBehaviour
{
    [SerializeField] private float bounceForce = 5f;
    [SerializeField] private float bounceForceMultiplier = 0.1f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        ResetPosition();
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // Increase the ball's speed
            rb.AddForce(rb.linearVelocity.normalized * bounceForceMultiplier, ForceMode2D.Impulse);
        }
    }

    public void ResetPosition()
    {
        // Reset the ball's position to the center of the screen
        transform.position = new Vector3(0, 0, 1);
        rb.linearVelocity = Vector2.zero;

        // Send the ball moving in a random direction
        rb.AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * bounceForce, ForceMode2D.Impulse);
    }
}
