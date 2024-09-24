using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
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
       
        Vector3 mousePos = Input.mousePosition;
        mousePos.Normalize();
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.transform.position.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
    }
}
