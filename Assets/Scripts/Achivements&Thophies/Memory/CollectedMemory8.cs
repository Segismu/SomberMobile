using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory8 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach8MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
