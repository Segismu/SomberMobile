using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.achFirstMemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
