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

    void Update()
    {
        if (Time.timeScale >= 1)
        {
            FaceMouseDir();
        }
   
    }
    public void FaceMouseDir()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousepos - new Vector2(transform.position.x, transform.position.y);
    }
}
