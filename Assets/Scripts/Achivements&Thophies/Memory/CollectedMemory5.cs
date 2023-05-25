using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedMemory5 : MonoBehaviour
{
    //[SerializeField] AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        AchivementController.ach5MemoryCount += 1;
        //collectSound.Play();
        Destroy(gameObject);
    }
}
