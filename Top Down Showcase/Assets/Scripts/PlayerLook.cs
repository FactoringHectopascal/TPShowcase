using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    //DOCUMENTATION FOR THIS: https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Transform-position.html
    // https://docs.unity3d.com/ScriptReference/Input-mousePosition.html
    // https://docs.unity3d.com/ScriptReference/Transform.LookAt.html
    // https://docs.unity3d.com/ScriptReference/Camera.ScreenToWorldPoint.html
    // https://docs.unity3d.com/ScriptReference/Vector3-up.html (Literally just a shorthand)
    //DOES NOT WORK IF THE CAMERA IS A CHILD OF THE PLAYER GAMEOBJECT, USE THIS IN CONJUCTION
    //WITH A CAMERA FOLLOW SCRIPT

    void Update()
    {
        if (Time.timeScale >= 1)
        {
            FaceMouseDir();
            //if the timescale isn't 0 or <0, allow me to run this function
        }

    }
    public void FaceMouseDir()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //converts the mouses position to worldspace, instead of screenspace.
        transform.up = mousepos - new Vector2(transform.position.x, transform.position.y);
        //moves the game objects rotation and y axis according to the mouse position - transform.x & y
    }
}
