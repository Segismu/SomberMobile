using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory21 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach21MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
