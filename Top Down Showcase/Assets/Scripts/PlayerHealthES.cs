using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthES : MonoBehaviour
{
    [SerializeField]
    float health = 10;
    [SerializeField]
    float maxHealth;
    [SerializeField]
    Image healthBar;
    [SerializeField]
    float healthregen = 2;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void regen()
    {
        if (health < 3)
        {
            health += healthregen * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health -= 1;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
