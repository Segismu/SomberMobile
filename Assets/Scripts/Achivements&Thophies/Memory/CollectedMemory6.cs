using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory6 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.ach6MemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
