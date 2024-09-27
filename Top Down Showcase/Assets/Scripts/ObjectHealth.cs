using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHealth : MonoBehaviour
{
    [SerializeField]
    float health = 15;
    [SerializeField]
    GameObject drop;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
            if(health <= 0)
            {
                Instantiate(drop, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
      if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}