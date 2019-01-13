using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    [SerializeField] float bounceForce;

    private void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            Rigidbody2D rb = hitInfo.gameObject.GetComponent<Rigidbody2D>();

            rb.velocity = new Vector2(rb.velocity.x, bounceForce);
        }
    }
}
