using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory16 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach16MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
