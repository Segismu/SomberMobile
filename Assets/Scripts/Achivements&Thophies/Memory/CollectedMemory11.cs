using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory11 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach11MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
