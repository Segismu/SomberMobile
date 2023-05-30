using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory4 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach4MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
