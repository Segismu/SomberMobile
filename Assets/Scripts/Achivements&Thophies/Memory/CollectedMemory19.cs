using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory19 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach19MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
