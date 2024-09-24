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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.LookAt(mousePos);
    }
}
