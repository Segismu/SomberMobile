using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory15 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach15MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
