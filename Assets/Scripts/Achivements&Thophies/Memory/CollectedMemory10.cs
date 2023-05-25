using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory10 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach10MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
