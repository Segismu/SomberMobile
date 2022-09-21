using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifications : MonoBehaviour
{
    [SerializeField] Canvas notificationCanvas;

    void Start()
    {
        StartCoroutine(notificationPopup());
    }

    IEnumerator notificationPopup()
    {
        yield return new WaitForSeconds(10);
        notificationCanvas.enabled = false;
    }
}
