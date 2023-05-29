using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory18 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach18MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
