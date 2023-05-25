using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory7 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach7MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
