using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthES : MonoBehaviour
{
    [SerializeField]
    public float health = 10;
    [SerializeField]
    public float maxHealth = 10;
    [SerializeField]
    Image healthBar;
    [SerializeField]
    GameObject Shield;
    public void Start()
    {
        maxHealth = health;

    }
    [SerializeField]
    string LevelLose;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            if (GetComponent<PlayerMovement>().rolling <= 0) // if the player is not rolling
            {
                health -= 1;
                healthBar.fillAmount = health / maxHealth;
                if (health <= 0)
                {
                    SceneManager.LoadScene(LevelLose);
                }

            }
        }
            if (collision.gameObject.tag == "mine")
            {
                health -= 2;
                healthBar.fillAmount = health / maxHealth;
                if (health <= 0)
                {
                    SceneManager.LoadScene(LevelLose);
                }
            }
            if (collision.gameObject.tag == "medkit")
            {
                health += 2;
                healthBar.fillAmount = health / maxHealth;
                if (health > maxHealth)
                {
                    health = maxHealth;
                }
            }
            if (collision.gameObject.tag == "shieldbox")
            {
                Instantiate(Shield, transform.position, Quaternion.identity);
            }
        

    }
}
