using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public GameObject player;
    private bool isInKaffe;
    public Texture backgroundNormal;
    public Texture backgroundInverted;
    public Material backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        isInKaffe = player.GetComponent<GravityChanger>().sockerInKaffe;

        if (isInKaffe)
        {
            backgroundRenderer.mainTexture = backgroundInverted;
        }
        else
        {
            backgroundRenderer.mainTexture = backgroundNormal;
        }
    }
}
