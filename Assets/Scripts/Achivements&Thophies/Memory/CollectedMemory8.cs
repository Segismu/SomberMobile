using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory8 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach8MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
