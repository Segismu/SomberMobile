using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory2 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach2MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
