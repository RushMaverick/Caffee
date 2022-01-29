using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public Vector3 offset;
    public Transform playerTransform;
    public Rigidbody2D playerRB;
    float velocity;
    float camDistance;

    void Update()
    {
        velocity = playerRB.transform.position.y;
        camDistance = offset.z * velocity;
        //Debug.Log("DISTANCE" + camDistance);

        if (camDistance > 0)
        {
            camDistance *= -1.0f;
        }

        if (camDistance >= -20)
        {
            camDistance = -20;
        }

        transform.position = new Vector3(playerTransform.position.x + offset.x, playerTransform.position.y + offset.y, camDistance); // Camera follows the player with specified offset position
        
    }
}
