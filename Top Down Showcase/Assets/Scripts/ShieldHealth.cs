using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShieldHealth : MonoBehaviour
{
    [SerializeField]
    public float health = 10;
    [SerializeField]
    public float maxHealth = 10;
    public void Start()
    {
        maxHealth = health;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
