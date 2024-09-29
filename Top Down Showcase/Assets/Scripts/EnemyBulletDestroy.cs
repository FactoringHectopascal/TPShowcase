using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Enemy")
        {
            if(collision.gameObject.tag != "boss")
            {
                if(collision.gameObject.tag != "minion")
                {
                       Destroy(gameObject);
                }
            }
        }
    }
}
