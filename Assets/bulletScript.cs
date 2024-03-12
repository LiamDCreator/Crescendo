using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
   public float bulletTime;
    void Start()
    {
        
       


      

        // Ignore collisions with the player
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
        }
    }

    private void Update(){

          bulletTime -= Time.deltaTime;
          if(bulletTime <= 0){

             Destroy(this.gameObject);
          }
    }
      private void OnCollisionEnter2D(Collision2D collision){
  if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "bullet")
        {
        Destroy(this.gameObject);

        }
        
        
        
        }

      


 
}
