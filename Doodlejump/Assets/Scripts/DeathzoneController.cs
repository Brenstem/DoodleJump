using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathzoneController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            hitInfo.GetComponent<Health>().TakeDamage(1);
        }
    }
}
