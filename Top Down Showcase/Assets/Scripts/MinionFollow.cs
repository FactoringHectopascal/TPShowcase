using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionFollow : MonoBehaviour
{
    [SerializeField]
    GameObject boss;
    private void Start()
    {
        boss = GameObject.FindGameObjectWithTag("boss");
    }
    void Update()
    {
        transform.position = new Vector2(boss.transform.position.x + 2, boss.transform.position.y + 2);
    }
}
