using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageController : MonoBehaviour
{
    [SerializeField] private int Damage;
    [SerializeField] private HPController hpManager;
    [SerializeField] ParticleSystem bugExplosion;
    [SerializeField] float deathDelay = 1f;


    protected virtual void Intro()

    {
        Debug.Log("Te pego objeto corriente de casa.");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bugExplosion.Play();
            DamageDealer();
            Intro();
        }
    }

    void DamageDealer()
    {
        
        hpManager.playerHP = hpManager.playerHP - Damage;
        hpManager.UpdateHP();
        Invoke("EnemyEraser", deathDelay);

        //Esto es provisorio. La idea es que los bichos vivan mas


    }

    protected virtual void EnemyEraser()
    {
        
        Destroy(gameObject);
    }

    
}
