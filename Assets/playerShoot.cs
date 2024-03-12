using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
      public GameObject bulletPrefab; // The prefab of the bullet object
      public float shootSpeed;
    public Transform shootPoint; // The point from which the player will shoot
    private Vector2 leftRight;
    // Update is called once per frame
    void Update()
    {

          if (Input.GetKeyDown(KeyCode.D)){
                leftRight = Vector2.right;
            }
            
         if (Input.GetKeyDown(KeyCode.A)){
                leftRight = Vector2.left;
            }

        // Check for shooting input
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Determine the direction based on the last movement
            Vector2 shootDirection = Vector2.zero;
            if (Input.GetKey(KeyCode.D))
                shootDirection = Vector2.right;
                
            
            else if (Input.GetKey(KeyCode.A))
                shootDirection = Vector2.left;
               

            else if (Input.GetKey(KeyCode.W))
                shootDirection = Vector2.up;
            else if (Input.GetKey(KeyCode.S))
                shootDirection = Vector2.down;
            else
                shootDirection = leftRight; // Default shooting direction

            // Shoot in the determined direction
            Shoot(shootDirection);
        }
    }

    void Shoot(Vector2 direction)
    {
        // Instantiate bullet at the shoot point
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        // Get the rigidbody of the bullet
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Apply force to the bullet in the specified direction
        rb.velocity = direction * shootSpeed; // Adjust the speed as needed
    }
}