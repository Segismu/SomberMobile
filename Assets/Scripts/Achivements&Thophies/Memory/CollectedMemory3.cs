using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory3 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach3MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
