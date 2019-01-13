using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] [Range(0,1)]float smoothspeed;
    [SerializeField] Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
        transform.position = smoothedPosition;
    }
}

