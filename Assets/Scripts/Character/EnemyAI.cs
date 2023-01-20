using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float enemyAwareness;
    [SerializeField] LayerMask playerLayer;
    [SerializeField] Transform player;
    [SerializeField] float movSpeed;

    bool isAware;

    void Start()
    {
        
    }

  
    void Update()
    {
       isAware = Physics.CheckSphere(transform.position, enemyAwareness, playerLayer);
        if (isAware == true)
        {
            Vector3 playerPos = new Vector3 (player.position.x, player.position.y, player.position.z);
            //transform.LookAt(player);
            transform.LookAt(playerPos);
            transform.position = Vector3.MoveTowards(transform.position, playerPos, movSpeed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, enemyAwareness);
    }
}
