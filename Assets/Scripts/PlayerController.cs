using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private float movementDirection = 0f;
    private bool moving = false;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moving = Input.GetKey(upKey) || Input.GetKey(downKey);

        if (Input.GetKey(upKey))
        {
            movementDirection = 1f;
        }
        else if (Input.GetKey(downKey))
        {
            movementDirection = -1f;
        }
        else
        {
            movementDirection = 0f;
        }
    }

    void FixedUpdate()
    {
        if (moving)
        {
            rb.AddForce(new Vector2(0, movementDirection * 10f));
        }
    }
}
