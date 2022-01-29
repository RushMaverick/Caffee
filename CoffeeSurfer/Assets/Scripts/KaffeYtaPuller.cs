using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaffeYtaPuller : MonoBehaviour
{
    SpriteRenderer cupObject;

    Collider2D cupCollider;
    Collider2D sugarCollider;
    
    public Sprite spriteNormal;
    public Sprite spriteInverted;

    float gravity;
    float newGravity;


    // Start is called before the first frame update
    void Start()
    {
        cupCollider = GameObject.FindGameObjectWithTag("kaffeyta").GetComponent<Collider2D>();
        sugarCollider = GameObject.FindGameObjectWithTag("socker").GetComponent<Collider2D>();

        cupObject = GameObject.FindGameObjectWithTag("kaffekopp").GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()

    {
        gravity = Physics2D.gravity.y;

        if (sugarCollider.IsTouching(cupCollider))
        {
            //Debug.Log("Collision!");
            if (gravity < 0 & !Input.GetKey("space"))
            {
                Debug.Log(Physics2D.gravity.y);
                Debug.Log("Flipping!");
                Physics2D.gravity = new Vector2(0, gravity * -1.0f);
                Debug.Log(Physics2D.gravity.y);

                cupObject.sprite = spriteInverted;
            }
            
        }
        if (gravity > 0 && !sugarCollider.IsTouching(cupCollider))
        {
            Debug.Log("Flipping back!");
            Physics2D.gravity = new Vector2(0, -9.8f);
            cupObject.sprite = spriteNormal;
        }
        
    }
}
