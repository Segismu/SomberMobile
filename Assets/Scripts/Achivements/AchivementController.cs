using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementController : MonoBehaviour
{
    public GameObject achNotification;
    public AudioSource achSound;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDescription;

    public GameObject achFirstMemoryImage;
    public static int achFirstMemoryCount;
    public int achFirstMemoryTrigger = 1;
    public int achFirstMemoryCode;

    void Update()
    {
        if (achFirstMemoryCount == achFirstMemoryTrigger && achFirstMemoryCode != 00001)
        {
            StartCoroutine(TriggerFirstMemoryAch());
        }
    }

    IEnumerator TriggerFirstMemoryAch()
    {
        achActive = true;
        achFirstMemoryCode = 00001;
        PlayerPrefs.SetInt("AchFirstMemory", achFirstMemoryCode);
        achSound.Play();
        achFirstMemoryImage.SetActive(true);
        achTitle.GetComponent<Text>().text = "Collection";
        achDescription.GetComponent<Text>().text = "Created a collection base achivement.";
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);

        achNotification.SetActive(false);
        achFirstMemoryImage.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDescription.GetComponent<Text>().text = "";
        achActive = false;

    }
}
