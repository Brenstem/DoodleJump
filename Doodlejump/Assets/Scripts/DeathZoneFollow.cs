using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [Range(3, 10)] [SerializeField] float yOffset;

    private void Update()
    {
        if (target.position.y - yOffset > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, target.position.y - yOffset);
        }
    }

}
