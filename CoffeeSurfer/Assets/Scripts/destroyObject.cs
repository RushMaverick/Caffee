using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{

    public int seconds;
    // Start is called before the first frame update
    void Start()
    {

        Destroy(this.gameObject, seconds);

    }
    /**
    private void onCollision2D(Collider2D collision)
    {
        Debug.Log("delete lol");
        if (collision.tag == "border")
        {
            Destroy(this.gameObject);
        }
    }**/

}
