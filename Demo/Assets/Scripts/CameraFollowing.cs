using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    Transform boy_position;
    Vector3 distance;
    public static int CamSpeed;
    void Start()
    {
        CamSpeed = 4;
        boy_position = GameObject.FindWithTag("Player").transform;
    }


    void LateUpdate()
    {
        distance = new Vector3(boy_position.position.x, boy_position.position.y + 10 ,boy_position.position.z  -7f);

        transform.position = Vector3.Lerp(transform.position, distance,CamSpeed* Time.deltaTime);

    }
}

