using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCameraPosition : MonoBehaviour
{
    Vector3 CamLastPosition;
    Vector3 CamLastRotation;
    float View;
    void Start()
    {
        CamLastPosition=new Vector3(-0.07338928f,2.3f,115.21f);
        CamLastRotation=new Vector3(3f,3.45f,0f);
        View=82;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.Lerp(transform.position,CamLastPosition,Time.deltaTime);
        transform.rotation = Quaternion.Euler(3f,3.45f,0f);
        Camera.main.fieldOfView=View;
    }
}
