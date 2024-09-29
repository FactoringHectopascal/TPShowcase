using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float shootSpeed = 10f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    [SerializeField]
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.5f;
    GameObject player;
    [SerializeField]
    float shootRange = 5f;
    [SerializeField]
    float shotLeadMult = 1f;
    [SerializeField]
    float shotVariance = 10f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = player.transform.position - transform.position + new Vector3(
            (player.GetComponent<Rigidbody2D>().velocity.x * shotLeadMult) + UnityEngine.Random.Range(-1 * shotVariance, shotVariance),
            (player.GetComponent<Rigidbody2D>().velocity.y * shotLeadMult) + UnityEngine.Random.Range(-1 * shotVariance, shotVariance), 0);
        if(timer > shootDelay && shootDir.magnitude <= shootRange)
            // kind of dense, add to the shootdirection the velocity of the player * a fudge factor, plus the shot variance
        {
            timer = 0;
            shootDir.Normalize();
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * shootSpeed;
            Destroy(bullet, bulletLifetime);
            
        }
    }
}
