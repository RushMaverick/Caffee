using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class zoomScript : MonoBehaviour
{

    float zoomSpeed = 3f;
    float zoomInMax = 40f;
    float zoomOutMax = 90f;
    public Rigidbody2D playerRB;

    public CinemachineVirtualCamera virtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float increment = playerRB.transform.position.y;
        if(increment < 0)
        {
            increment = 0;
        }

        ZoomScreen(increment * -1f);
    }

    public void ZoomScreen(float increment)
    {
        float fov = virtualCamera.m_Lens.FieldOfView;
        float target = Mathf.Clamp(fov + increment, zoomInMax, zoomOutMax);
        virtualCamera.m_Lens.FieldOfView = Mathf.Lerp(fov, target, zoomSpeed * Time.deltaTime);
    }
}
