using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory13 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach13MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
