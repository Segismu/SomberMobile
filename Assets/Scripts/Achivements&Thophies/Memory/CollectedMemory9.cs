using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory9 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach9MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
