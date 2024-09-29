using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x + 1, player.transform.position.y + 1);
    }
}
