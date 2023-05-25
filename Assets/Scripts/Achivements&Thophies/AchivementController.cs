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

    public int ach4MemoryTrigger = 1;
    public int ach4MemoryCode;
    public static int ach4MemoryCount;

    public int ach5MemoryTrigger = 1;
    public int ach5MemoryCode;
    public static int ach5MemoryCount;

    public int ach6MemoryTrigger = 1;
    public int ach6MemoryCode;
    public static int ach6MemoryCount;

    public int ach7MemoryTrigger = 1;
    public int ach7MemoryCode;
    public static int ach7MemoryCount;

    public int ach8MemoryTrigger = 1;
    public int ach8MemoryCode;
    public static int ach8MemoryCount;

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

        ach4MemoryCode = PlayerPrefs.GetInt("Ach4Memory");
        if (ach4MemoryCount == ach4MemoryTrigger && ach4MemoryCode != 00004)
        {
            StartCoroutine(Trigger4MemoryAch());
        }

        ach5MemoryCode = PlayerPrefs.GetInt("Ach5Memory");
        if (ach5MemoryCount == ach5MemoryTrigger && ach5MemoryCode != 00005)
        {
            StartCoroutine(Trigger5MemoryAch());
        }

        ach6MemoryCode = PlayerPrefs.GetInt("Ach6Memory");
        if (ach6MemoryCount == ach6MemoryTrigger && ach6MemoryCode != 00006)
        {
            StartCoroutine(Trigger6MemoryAch());
        }

        ach7MemoryCode = PlayerPrefs.GetInt("Ach7Memory");
        if (ach7MemoryCount == ach7MemoryTrigger && ach7MemoryCode != 00007)
        {
            StartCoroutine(Trigger7MemoryAch());
        }

        ach8MemoryCode = PlayerPrefs.GetInt("Ach8Memory");
        if (ach8MemoryCount == ach8MemoryTrigger && ach8MemoryCode != 00008)
        {
            StartCoroutine(Trigger8MemoryAch());
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

    IEnumerator Trigger4MemoryAch()
    {
        achActive = true;
        ach4MemoryCode = 00004;
        PlayerPrefs.SetInt("Ach4Memory", ach4MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
        achActive = false;
    }

    IEnumerator Trigger5MemoryAch()
    {
        achActive = true;
        ach5MemoryCode = 00005;
        PlayerPrefs.SetInt("Ach5Memory", ach5MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
        achActive = false;
    }

    IEnumerator Trigger6MemoryAch()
    {
        achActive = true;
        ach6MemoryCode = 00006;
        PlayerPrefs.SetInt("Ach6Memory", ach6MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
        achActive = false;
    }

    IEnumerator Trigger7MemoryAch()
    {
        achActive = true;
        ach7MemoryCode = 00007;
        PlayerPrefs.SetInt("Ach7Memory", ach7MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
        achActive = false;
    }

    IEnumerator Trigger8MemoryAch()
    {
        achActive = true;
        ach8MemoryCode = 00008;
        PlayerPrefs.SetInt("Ach8Memory", ach8MemoryCode);
        achNotification.SetActive(true);
        yield return new WaitForSeconds(5);
        achNotification.SetActive(false);
        achActive = false;
    }
}
