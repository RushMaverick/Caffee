using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoppMover : MonoBehaviour
{
    //public Rigidbody2D playerRB;
    float velocity;
    public float needforspeed;
    public Rigidbody2D playerRB;

    // Update is called once per frame
    void Update()
    {
        velocity = playerRB.velocity.y;
        transform.Translate(-Vector3.right * needforspeed * Time.deltaTime);
    }
}
