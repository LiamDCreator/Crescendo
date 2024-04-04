using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class softPlatformScript : MonoBehaviour
{
   private Rigidbody2D rb;
    public string playerTag = "player";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), 
                                  GameObject.FindGameObjectWithTag(playerTag).GetComponent<Collider2D>(), 
                                  transform.position.y > GameObject.FindGameObjectWithTag(playerTag).transform.position.y);
    }
}