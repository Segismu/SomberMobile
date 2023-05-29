using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory9 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach9MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
