using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory5 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach5MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
