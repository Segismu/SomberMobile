using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory12 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach12MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
