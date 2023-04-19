using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] float deathDelay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroying();
        }
    }

    void Destroying()
    {
        Destroy(gameObject);
        Invoke("EnemyEraser", deathDelay);
    }
}

