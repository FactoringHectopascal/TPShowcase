using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
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
    float parrytimer = 2f;
    [SerializeField]
    bool parryCooldown = false;

    private void Start()
    {
        maxHealth = health;
        
    }
    [SerializeField]
    string LevelLose;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health -= 1;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                SceneManager.LoadScene(LevelLose);
            }
        }
    }
    
}
