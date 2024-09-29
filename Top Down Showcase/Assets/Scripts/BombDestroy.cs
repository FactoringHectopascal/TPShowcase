using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag != "Player")
        {
            if (collision.gameObject.tag != "shield")
            {
                if (collision.gameObject.tag != "partner")
                {
                    if(collision.gameObject.tag != "EnemyBullet")
                    {
                       Destroy(gameObject);
                    }
                }
            }
        }

    }
}
