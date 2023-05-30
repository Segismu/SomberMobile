using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider Testis)
    {
        if (Testis.tag == "Player")
        {
            AchivementController.achFirstMemoryCount++;
            collectSound.Play();
            Destroy(gameObject);
        }
    }
}
