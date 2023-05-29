using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory6 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach6MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
