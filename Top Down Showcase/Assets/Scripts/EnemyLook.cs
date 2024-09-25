using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void FacePlayer()
    {
        transform.up = player.transform.position - transform.position;
    }

    void Update()
    {
        FacePlayer(); 
    }
}
