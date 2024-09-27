using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthES : MonoBehaviour
{
    [SerializeField]
    float health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
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