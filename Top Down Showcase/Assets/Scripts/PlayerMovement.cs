using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 10f;
    [SerializeField]
    float runSpeed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "speedboost")
        {
            runSpeed += .5f;
            moveSpeed += 1f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //check for horizontal and vvertical input
        //move the player based on that input.
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        //Velocity is a Vector2 variable, which stores 
        //two floats, x and y.
        GetComponent<Rigidbody2D>().velocity = new Vector2 (xInput, yInput) * moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, yInput) * runSpeed;
        }
        

   

     }
}
