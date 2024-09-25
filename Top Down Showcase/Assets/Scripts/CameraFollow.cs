using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    //allows me to set the transform target (so I can choose what I want the camera to follow)
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        //Sets the transform position to the targets x and y values, while still retaining the z values
        //so that it does not clip through the floor.
    }
}
