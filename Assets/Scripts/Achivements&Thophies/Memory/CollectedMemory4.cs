using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory4 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach4MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
