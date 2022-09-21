using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationTriggerer : MonoBehaviour
{
    [Header("To Sleep")]
    public UnityEvent myEvents;

    private void OnTriggerEnter(Collider other)
    {
        if (myEvents == null)
        {
            return;
        }
        else
        {
            myEvents.Invoke();
        }
    }
}
