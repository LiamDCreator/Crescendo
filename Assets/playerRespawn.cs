using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
      public Transform[] respawnPoints;

   

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null && player.transform.position.y < -6f)
        {
            Transform closestRespawnPoint = FindClosestRespawnPoint(player.transform.position);
            player.transform.position = closestRespawnPoint.position;
        }
         GameObject player2 = GameObject.FindGameObjectWithTag("player2");
        if (player2 != null && player2.transform.position.y < -6f)
        {
            Transform closestRespawnPoint = FindClosestRespawnPoint(player2.transform.position);
            player2.transform.position = closestRespawnPoint.position;
        }
    }
    

    Transform FindClosestRespawnPoint(Vector3 playerPosition)
    {
        Transform closestRespawnPoint = null;
        float closestDistance = Mathf.Infinity;

        foreach (Transform respawnPoint in respawnPoints)
        {
            float distance = Vector3.Distance(playerPosition, respawnPoint.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestRespawnPoint = respawnPoint;
            }
        }

        return closestRespawnPoint;
    }

}
