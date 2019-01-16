using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Serialized variables
    [SerializeField] float lifeLength;
    [SerializeField] float speed;

    // Private variables
    private Rigidbody2D rb;
    private float lifeTimer;

    // Unity functions
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    private void Update()
    {
        lifeTimer += Time.fixedDeltaTime;

        if (lifeTimer > lifeLength)
        {
            Destroy(this.gameObject);
        }
    }
}
