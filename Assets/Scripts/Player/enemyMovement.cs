using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

    void Awake ()
    {
        //Cari gameobject dengan tag player
        player = GameObject.FindGameObjectWithTag ("Player").transform;
 
        //Mendapatkan Reference component
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }
    


    void Update ()
    {
        //Memindahkan posisi player
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth> 0)
        {
           nav.SetDestination(player.position);
        }
        else //Hentikan moving
        {
            nav.enabled = false;
        }
    }
}
