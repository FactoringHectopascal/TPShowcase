using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthES : MonoBehaviour
{
    [SerializeField]
    float health = 3;
    float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }

        }
    }
}