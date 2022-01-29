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
        //velocity = Mathf.Log(Mathf.Abs(playerRB.velocity.y));
        velocity = Mathf.Log(Mathf.Abs(Physics2D.gravity.y));
        transform.Translate(-Vector3.right * needforspeed * velocity * Time.deltaTime);
    }
}
