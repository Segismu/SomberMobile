using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory20 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach20MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
