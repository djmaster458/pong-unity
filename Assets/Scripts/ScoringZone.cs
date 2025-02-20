using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class ScoringZone : MonoBehaviour
{
    [SerializeField] private UnityEvent onScore;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // If the ball collides with the scoring zone
        if(collision.gameObject.CompareTag("Ball"))
        {
            // Fire an event
            onScore.Invoke();
        }
    }
}
