using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory17 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach17MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
