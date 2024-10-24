using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript2 : MonoBehaviour
{
      public float moveSpeed = 5f;
    public float jumpForce = 10f; 
    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundMask;
    public int crescendoCount;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal2");

       
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);

      
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);

       
        if (Input.GetKeyDown(KeyCode.RightControl) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); // jump
          
        }
        crescendoBuff();
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
        if (collision.gameObject.CompareTag("bulletP1")) 
        {
           Debug.Log("yaay");
            
        }
        }




    public void crescendoBuff(){
        if(crescendoCount == 0){
            moveSpeed = 7;
        }
        if(crescendoCount == 1){
            moveSpeed = 11;
        }
        if(crescendoCount == 2){
            moveSpeed = 15;
        }
    }
}