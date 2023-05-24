using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementController : MonoBehaviour
{
    [SerializeField] GameObject achNotification;
    public bool achActive = false;

    public int achFirstMemoryTrigger = 1;
    public int achFirstMemoryCode;
    public static int achFirstMemoryCount = 0;

    public int ach2MemoryTrigger = 1;
    public int ach2MemoryCode;
    public static int ach2MemoryCount;

    public int ach3MemoryTrigger = 1;
    public int ach3MemoryCode;
    public static int ach3MemoryCount;

    void Update()
    {
        achFirstMemoryCode = PlayerPrefs.GetInt("AchFirstMemory");
        if (achFirstMemoryCount == achFirstMemoryTrigger && achFirstMemoryCode != 00001)
        {
            StartCoroutine(TriggerFirstMemoryAch());
        }

        ach2MemoryCode = PlayerPrefs.GetInt("Ach2Memory");
        if (ach2MemoryCount == ach2MemoryTrigger && ach2MemoryCode != 00002)
        {
            StartCoroutine(Trigger2MemoryAch());
        }

        ach3MemoryCode = PlayerPrefs.GetInt("Ach3Memory");
        if (ach3MemoryCount == ach3MemoryTrigger && ach3MemoryCode != 00003)
        {
            StartCoroutine(Trigger3MemoryAch());
        }
    }

    IEnumerator TriggerFirstMemoryAch()
    {
        achActive = true;
        achFirstMemoryCode = 00001;
        PlayerPrefs.SetInt("AchFirstMemory", achFirstMemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
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

    IEnumerator Trigger3MemoryAch()
    {
        achActive = true;
        ach3MemoryCode = 00003;
        PlayerPrefs.SetInt("Ach3Memory", ach3MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
        achActive = false;
    }
}
