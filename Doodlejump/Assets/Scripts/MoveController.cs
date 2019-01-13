using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool autoMove;

    private Rigidbody2D rb;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (autoMove)
            horizontalInput = 1;
    }

    private void Update()
    {
        if (!autoMove)
            horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (autoMove)
            horizontalInput = -horizontalInput; //Debug.Log("meme");

    }
}
