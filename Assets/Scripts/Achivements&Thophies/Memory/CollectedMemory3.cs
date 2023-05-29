using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory3 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach3MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
