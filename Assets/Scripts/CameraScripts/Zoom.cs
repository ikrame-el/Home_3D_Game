using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Zoom : MonoBehaviour
{
    Camera mainCamera;
    float zoom;
    public float speed = 1f;

    void Start()
    {

        mainCamera = GetComponent<Camera>();
        zoom = mainCamera.orthographicSize;
    }

    void Update()
    {
        float zoomDelta = Input.GetAxis("Zoom") * speed;
        zoom += zoomDelta;

        if (zoom>=0)
        {
            mainCamera.orthographicSize = zoom;
        }
    }


}
