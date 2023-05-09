using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool jumpKeyPressed;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();      
    }
    
    private void Update()
    {

        //Character Movement
        float directX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(directX * 8f, rb.velocity.y);
        

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 12f);
       
            jumpKeyPressed = true;

        }
    }
    
    private void FixedUpdate()
    {
        if (jumpKeyPressed)
        {
            rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            
            jumpKeyPressed = false;
        }
        
    }
}
