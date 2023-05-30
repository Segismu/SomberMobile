using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory7 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach7MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
