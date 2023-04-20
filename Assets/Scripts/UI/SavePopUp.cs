using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePopUp : MonoBehaviour
{

    [SerializeField] GameObject savedCanvas;
    bool wasTouched = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && wasTouched == false)
        {
            savedCanvas.SetActive(true);
            StartCoroutine(WaitForPopUP());
            wasTouched = true;
        }
    }

    IEnumerator WaitForPopUP()
    {
        yield return new WaitForSeconds(5);
        savedCanvas.SetActive(false);
    }
}

