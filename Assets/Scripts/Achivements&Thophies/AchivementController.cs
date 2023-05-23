using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementController : MonoBehaviour
{
    [SerializeField] GameObject achNotification;
    //[SerializeField] AudioSource achSound;
    //[SerializeField] GameObject achTitle;
    //public GameObject achDescription;
    public bool achActive = false;

    //[SerializeField] GameObject achFirstMemoryImage;
    public int achFirstMemoryTrigger = 2;
    public int achFirstMemoryCode;
    public static int achFirstMemoryCount;

    public int ach2MemoryTrigger = 2;
    public int ach2MemoryCode;
    public static int ach2MemoryCount;

    void Update()
    {
        achFirstMemoryCode = PlayerPrefs.GetInt("AchFirstMemory");
        if (achFirstMemoryCount == achFirstMemoryTrigger && achFirstMemoryCode != 00001)
        {
            StartCoroutine(TriggerFirstMemoryAch());
        }

        achFirstMemoryCode = PlayerPrefs.GetInt("Ach2Memory");
        if (ach2MemoryCount == ach2MemoryTrigger && ach2MemoryCode != 00002)
        {
            StartCoroutine(Trigger2MemoryAch());
        }
    }

    IEnumerator TriggerFirstMemoryAch()
    {
        achActive = true;
        achFirstMemoryCode = 00001;
        PlayerPrefs.SetInt("AchFirstMemory", achFirstMemoryCode);
        //achSound.Play();
        //achFirstMemoryImage.SetActive(true);
        //achTitle.GetComponent<Text>().text = "Collection";
        //achDescription.GetComponent<Text>().text = "Created a collection base achivement.";
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);

        achNotification.SetActive(false);
        //achFirstMemoryImage.SetActive(false);
        //achTitle.GetComponent<Text>().text = "";
        //achDescription.GetComponent<Text>().text = "";
        achActive = false;

    }

    IEnumerator Trigger2MemoryAch()
    {
        achActive = true;
        ach2MemoryCode = 00002;
        PlayerPrefs.SetInt("Ach2Memory", ach2MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);

        achNotification.SetActive(false);
        achActive = false;

    }
}
