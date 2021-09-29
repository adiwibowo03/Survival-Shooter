using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
 
 
    void Awake ()
    {
        //Cari gameobject with tag player
        player = GameObject.FindGameObjectWithTag ("Player").transform;
 
        //Mendapatkan componen reference
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }
 
 
    void Update ()
    {
        //Pindah ke player position
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth> 0)
        {
           nav.SetDestination(player.position);
        }
        else //Stop moving
        {
            nav.enabled = false;
        }
    }
}
