using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathzoneController : MonoBehaviour
{
    [SerializeField] Transform target;
    [Range (3, 5)][SerializeField] float yOffset;

    private void Update()
    {
        if (target.position.y - yOffset > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, target.position.y - yOffset);
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            hitInfo.GetComponent<Health>().TakeDamage(1);
        }
        else if (hitInfo.CompareTag("Platform"))
        {
            Destroy(hitInfo.gameObject);
        }
    }
}
