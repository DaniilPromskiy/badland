using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player; 
    [SerializeField] private Vector3 offset; 
    [SerializeField] private float smoothSpeed = 0.125f; 

    private void LateUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        
        Vector3 desiredPosition = player.position + offset;

        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}
