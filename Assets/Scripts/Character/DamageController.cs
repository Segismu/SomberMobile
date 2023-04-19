using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageController : MonoBehaviour
{
    [SerializeField] private HPController hpManager;

    [SerializeField] private int Damage;
    [SerializeField] float deathDelay = 1f;

    [SerializeField] ParticleSystem bugExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bugExplosion.Play();
            DamageDealer();
        }
    }

    void DamageDealer()
    {

        hpManager.playerHP = hpManager.playerHP - Damage;
        hpManager.UpdateHP();
        Invoke("EnemyEraser", deathDelay);
    }

    protected virtual void EnemyEraser()
    {
        Destroy(gameObject);
    }


}

