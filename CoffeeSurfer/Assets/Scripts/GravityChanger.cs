using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    bool isInCoffee;

    float gravity;
    float newGravity;
    float baseValue;
    float increaseExponential;
    float decreaseExponential;

    Collider2D cupCollider;
    Collider2D sugarCollider;

    // Start is called before the first frame update
    void Start()
    {
        baseValue = -9.8f;
        gravity = baseValue;
        newGravity = 0.0f;
        increaseExponential = 1.007f;
        decreaseExponential = 1.05f;

        cupCollider = GameObject.FindGameObjectWithTag("kaffeyta").GetComponent<Collider2D>();
        sugarCollider = GameObject.FindGameObjectWithTag("socker").GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        isInCoffee = sugarCollider.IsTouching(cupCollider);
        if (Input.GetKey("space"))
        {  
            
            Debug.Log("Adding gravity!");
            Debug.Log(newGravity);

            newGravity = Physics2D.gravity.y * increaseExponential;

            // The default is (0, -9.8).
            Physics2D.gravity = new Vector2(0, newGravity);
            


        }


        if (Physics2D.gravity.y < baseValue & !isInCoffee)
        {
            newGravity = gravity / decreaseExponential;
            gravity = newGravity;
            Physics2D.gravity = new Vector2(0, gravity);
        }
        /*if (Physics2D.gravity.y > baseValue & !isInCoffee)
        {
            Physics2D.gravity = new Vector2(0, baseValue);
            Debug.Log("Resetting gravity!");
        }*/

    }
}
