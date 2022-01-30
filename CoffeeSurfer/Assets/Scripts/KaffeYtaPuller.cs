using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaffeYtaPuller : MonoBehaviour
{
    GameObject[] cupObjects;
    Collider2D sugarCollider;

    public Sprite spriteNormal;
    public Sprite spriteInverted;

    float gravity;

    public GameObject player;

    public BoxCollider2D trigger;

    // Start is called before the first frame update
    void Start()
    {
        
        sugarCollider = player.GetComponent<Collider2D>();
        trigger = GetComponent<BoxCollider2D>();

    }

    bool sockerInKaffe = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "socker")
        {
            sockerInKaffe = true;

            var player = other.GetComponent<GravityChanger>();
            player.sockerInKaffe = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "socker")
        {
            sockerInKaffe = false;

            // If the player is not in coffee, tell them
            var player = other.GetComponent<GravityChanger>();
            player.sockerInKaffe = false;
        }
    }
}
