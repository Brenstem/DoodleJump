using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool autoMove;
    public float bounceForce;

    private Rigidbody2D rb;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (autoMove)
        {
            horizontalInput = 1;
        }
    }

    private void Update()
    {
        if (!autoMove)
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (autoMove)
        {
            horizontalInput = -horizontalInput;
        }

        rb.velocity = new Vector2(rb.velocity.x, bounceForce);
    }
}
