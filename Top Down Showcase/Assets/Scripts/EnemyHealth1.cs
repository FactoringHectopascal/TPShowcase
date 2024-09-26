using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth1 : MonoBehaviour
{
    [SerializeField]
    float health = 3;
    [SerializeField]
    Image healthBar;
    [SerializeField]
    float maxHealth;
    [SerializeField]
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        healthBar = GetComponentsInChildren<Image>()[0];
        healthBar.fillAmount = health / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                GameObject medkit = Instantiate(prefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
