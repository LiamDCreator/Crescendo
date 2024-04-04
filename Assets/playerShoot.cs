using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    
     public float shootSpeedWhistle1;
     public float shootSpeedWhistle2;
     public float shootSpeedWhistle3;

     public float shootCooldown;
      private float shootTimer;
      public GameObject bulletPrefabWhistle1;
      public GameObject bulletPrefabWhistle2; 
      public GameObject bulletPrefabWhistle3; 

    public Transform shootPoint; 
    public int whistleCount = 1; // whislte bullet the player is using. 3 types

    private Vector2 shootDirection = Vector2.right; // Default shooting direction

    
    void Update()
    {
           shootTimer -= Time.deltaTime;
        // Update the shoot direction based on movement keys
        if (Input.GetKeyDown(KeyCode.D))
        {
            shootDirection = Vector2.right;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            shootDirection = Vector2.left;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            shootDirection = Vector2.up;
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            shootDirection = Vector2.down;
        }

        // Check for shooting input
        if (Input.GetKeyDown(KeyCode.G) && shootTimer <= 0)
        {
            // Shoot in the determined direction
            ShootWhistle1(shootDirection);
            shootTimer = shootCooldown;
        }
    }
    void ShootWhistle1(Vector2 direction)
    {
     if(whistleCount == 1){
        GameObject bullet = Instantiate(bulletPrefabWhistle1, shootPoint.position, Quaternion.identity);
       bullet.tag = "bulletP1";
       
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = shootDirection * shootSpeedWhistle1; }


     if(whistleCount == 2){  
        GameObject bullet = Instantiate(bulletPrefabWhistle2, shootPoint.position, Quaternion.identity);
       bullet.tag = "bulletP1";

        shootCooldown =0.5f;

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = shootDirection * shootSpeedWhistle2; }


         if(whistleCount == 3){  
        GameObject bullet = Instantiate(bulletPrefabWhistle3, shootPoint.position, Quaternion.identity);
       bullet.tag = "bulletP1";
       
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        shootCooldown = 0.25f;
       
        rb.velocity = shootDirection * shootSpeedWhistle3; }
    }
    
     
    


    
}