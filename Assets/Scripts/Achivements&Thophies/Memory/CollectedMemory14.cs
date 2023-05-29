using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory14 : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach14MemoryCount += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
