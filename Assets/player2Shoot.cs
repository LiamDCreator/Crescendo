using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Shoot : MonoBehaviour
{
    
     public float shootSpeedWhistle1;
     public float shootSpeedWhistle2;
     public float shootSpeedWhistle3;

     public float shootCooldown; // cooldown per shot
      private float shootTimer; // timer
      public GameObject bulletPrefabWhistle1;
      public GameObject bulletPrefabWhistle2; 
      public GameObject bulletPrefabWhistle3; 

    public Transform shootPoint; // The point from which the player will shoot
    public int whistleCount = 1;

    private Vector2 shootDirection = Vector2.right; // Default shooting direction

    // Update is called once per frame
    void Update()
    {
           shootTimer -= Time.deltaTime;
        // Update the shoot direction based on movement keys
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            shootDirection = Vector2.right;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            shootDirection = Vector2.left;
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            shootDirection = Vector2.up;
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            shootDirection = Vector2.down;
        }

       
        if (Input.GetKeyDown(KeyCode.Return) && shootTimer <= 0)
        {
            
            ShootWhistle1(shootDirection); // shoot
            shootTimer = shootCooldown;
        }
    }
    void ShootWhistle1(Vector2 direction)
    {
     if(whistleCount == 1){
        GameObject bullet = Instantiate(bulletPrefabWhistle1, shootPoint.position, Quaternion.identity);
       bullet.tag = "bulletP2";
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = shootDirection * shootSpeedWhistle1; }


     if(whistleCount == 2){  
        GameObject bullet = Instantiate(bulletPrefabWhistle2, shootPoint.position, Quaternion.identity);
       bullet.tag = "bulletP2";

        shootCooldown =0.5f;

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = shootDirection * shootSpeedWhistle2; }


         if(whistleCount == 3){  
        GameObject bullet = Instantiate(bulletPrefabWhistle3, shootPoint.position, Quaternion.identity);
       bullet.tag = "bulletP2";
       
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        shootCooldown = 0.25f;
       
        rb.velocity = shootDirection * shootSpeedWhistle3; }
    }
    
     
    


    
}