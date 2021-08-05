using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomView : MonoBehaviour
{
    private Camera toZoom;
    private float fov;
    // Start is called before the first frame update
    void Start()
    {
        toZoom = GetComponent<Camera>();
        fov = toZoom.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Zoom"))
        {
            toZoom.fieldOfView = fov/1.5f;
        }
        else
        {
            toZoom.fieldOfView = fov;
        }
    }
}
