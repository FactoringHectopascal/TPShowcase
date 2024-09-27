using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float shootSpeed = 7f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.5f;
    
    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ammobox")
        {
            shootSpeed += 1f;
            shootDelay -= 0.005f;
        }
    }
    void Update()
    {
        timer += Time.deltaTime; // 0.01666666666s if 60f/s
        //If we press "the shoot button" (leftmouse)
        //the timescale check is so that the menu bug is fixed, so only when time is running you can fire
        if(Input.GetButton("Fire1") && timer > shootDelay && Time.timeScale == 1)
        {
            timer = 0;
            //fire a projectile in a straight line in the direction of the mouse
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            mousePos = mousePos - transform.position;
            mousePos.Normalize();
            //spawn in the bullet
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = mousePos * shootSpeed;
            Destroy(bullet, bulletLifetime);
            //Spawn (what are we spawning?, where?, rotation?)
            //Debug.Log(mousePos);
            //Uses pixel coordinates, meaning that it uses the boundaries of the monitor
            //Camera converts this onto its plane of existence, however this also includes the z value.
        }
    }

}
