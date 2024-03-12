using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    
     public float shootSpeed;

      public GameObject bulletPrefab; // The prefab of the bullet object
    public Transform shootPoint; // The point from which the player will shoot

    private Vector2 shootDirection = Vector2.right; // Default shooting direction

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKeyDown(KeyCode.G))
        {
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
        rb.velocity = shootDirection * shootSpeed; // Adjust the speed as needed
    }
}