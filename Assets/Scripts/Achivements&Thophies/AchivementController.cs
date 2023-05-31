using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementController : MonoBehaviour
{
    public bool achActive = false;

    public int achFirstMemoryTrigger = 1;
    public int achFirstMemoryCode;
    public static int achFirstMemoryCount = 1;

    public int ach2MemoryTrigger = 1;
    public int ach2MemoryCode;
    public static int ach2MemoryCount = 1;

    public int ach3MemoryTrigger = 1;
    public int ach3MemoryCode;
    public static int ach3MemoryCount = 1;

    public int ach4MemoryTrigger = 1;
    public int ach4MemoryCode;
    public static int ach4MemoryCount = 1;

    public int ach5MemoryTrigger = 1;
    public int ach5MemoryCode;
    public static int ach5MemoryCount = 1;

    public int ach6MemoryTrigger = 1;
    public int ach6MemoryCode;
    public static int ach6MemoryCount = 1;

    public int ach7MemoryTrigger = 1;
    public int ach7MemoryCode;
    public static int ach7MemoryCount = 1;

    public int ach8MemoryTrigger = 1;
    public int ach8MemoryCode;
    public static int ach8MemoryCount = 1;

    public int ach9MemoryTrigger = 1;
    public int ach9MemoryCode;
    public static int ach9MemoryCount = 1;

    public int ach10MemoryTrigger = 1;
    public int ach10MemoryCode;
    public static int ach10MemoryCount = 1;

    public int ach11MemoryTrigger = 1;
    public int ach11MemoryCode;
    public static int ach11MemoryCount = 1;

    public int ach12MemoryTrigger = 1;
    public int ach12MemoryCode;
    public static int ach12MemoryCount = 1;

    public int ach13MemoryTrigger = 1;
    public int ach13MemoryCode;
    public static int ach13MemoryCount = 1;

    public int ach14MemoryTrigger = 1;
    public int ach14MemoryCode;
    public static int ach14MemoryCount = 1;

    public int ach15MemoryTrigger = 1;
    public int ach15MemoryCode;
    public static int ach15MemoryCount = 1;

    public int ach16MemoryTrigger = 1;
    public int ach16MemoryCode;
    public static int ach16MemoryCount = 1;

    public int ach17MemoryTrigger = 1;
    public int ach17MemoryCode;
    public static int ach17MemoryCount = 1;

    public int ach18MemoryTrigger = 1;
    public int ach18MemoryCode;
    public static int ach18MemoryCount = 1;

    public int ach19MemoryTrigger = 1;
    public int ach19MemoryCode;
    public static int ach19MemoryCount = 1;

    public int ach20MemoryTrigger = 1;
    public int ach20MemoryCode;
    public static int ach20MemoryCount = 1;

    public int ach21MemoryTrigger = 1;
    public int ach21MemoryCode;
    public static int ach21MemoryCount = 1;

    void Update()
    {

        achFirstMemoryCode = PlayerPrefs.GetInt("AchFirstMemory");
        if (achFirstMemoryCount > achFirstMemoryTrigger && achFirstMemoryCode != 00001)
        {
            StartCoroutine(TriggerFirstMemoryAch());
        }

        ach2MemoryCode = PlayerPrefs.GetInt("Ach2Memory");
        if (ach2MemoryCount > ach2MemoryTrigger && ach2MemoryCode != 00002)
        {
            StartCoroutine(Trigger2MemoryAch());
        }

        ach3MemoryCode = PlayerPrefs.GetInt("Ach3Memory");
        if (ach3MemoryCount > ach3MemoryTrigger && ach3MemoryCode != 00003)
        {
            StartCoroutine(Trigger3MemoryAch());
        }

        ach4MemoryCode = PlayerPrefs.GetInt("Ach4Memory");
        if (ach4MemoryCount > ach4MemoryTrigger && ach4MemoryCode != 00004)
        {
            StartCoroutine(Trigger4MemoryAch());
        }

        ach5MemoryCode = PlayerPrefs.GetInt("Ach5Memory");
        if (ach5MemoryCount > ach5MemoryTrigger && ach5MemoryCode != 00005)
        {
            StartCoroutine(Trigger5MemoryAch());
        }

        ach6MemoryCode = PlayerPrefs.GetInt("Ach6Memory");
        if (ach6MemoryCount > ach6MemoryTrigger && ach6MemoryCode != 00006)
        {
            StartCoroutine(Trigger6MemoryAch());
        }

        ach7MemoryCode = PlayerPrefs.GetInt("Ach7Memory");
        if (ach7MemoryCount > ach7MemoryTrigger && ach7MemoryCode != 00007)
        {
            StartCoroutine(Trigger7MemoryAch());
        }

        ach8MemoryCode = PlayerPrefs.GetInt("Ach8Memory");
        if (ach8MemoryCount > ach8MemoryTrigger && ach8MemoryCode != 00008)
        {
            StartCoroutine(Trigger8MemoryAch());
        }

        ach9MemoryCode = PlayerPrefs.GetInt("Ach9Memory");
        if (ach9MemoryCount > ach9MemoryTrigger && ach9MemoryCode != 00009)
        {
            StartCoroutine(Trigger9MemoryAch());
        }

        ach10MemoryCode = PlayerPrefs.GetInt("Ach10Memory");
        if (ach10MemoryCount > ach10MemoryTrigger && ach10MemoryCode != 00010)
        {
            StartCoroutine(Trigger10MemoryAch());
        }

        ach11MemoryCode = PlayerPrefs.GetInt("Ach11Memory");
        if (ach11MemoryCount > ach11MemoryTrigger && ach11MemoryCode != 00011)
        {
            StartCoroutine(Trigger11MemoryAch());
        }

        ach12MemoryCode = PlayerPrefs.GetInt("Ach12Memory");
        if (ach12MemoryCount > ach12MemoryTrigger && ach12MemoryCode != 00012)
        {
            StartCoroutine(Trigger12MemoryAch());
        }

        ach13MemoryCode = PlayerPrefs.GetInt("Ach13Memory");
        if (ach13MemoryCount > ach13MemoryTrigger && ach13MemoryCode != 00013)
        {
            StartCoroutine(Trigger13MemoryAch());
        }

        ach14MemoryCode = PlayerPrefs.GetInt("Ach14Memory");
        if (ach14MemoryCount > ach14MemoryTrigger && ach14MemoryCode != 00014)
        {
            StartCoroutine(Trigger14MemoryAch());
        }

        ach15MemoryCode = PlayerPrefs.GetInt("Ach15Memory");
        if (ach15MemoryCount > ach15MemoryTrigger && ach15MemoryCode != 00015)
        {
            StartCoroutine(Trigger15MemoryAch());
        }

        ach16MemoryCode = PlayerPrefs.GetInt("Ach16Memory");
        if (ach16MemoryCount > ach16MemoryTrigger && ach16MemoryCode != 00016)
        {
            StartCoroutine(Trigger16MemoryAch());
        }

        ach17MemoryCode = PlayerPrefs.GetInt("Ach17Memory");
        if (ach17MemoryCount > ach17MemoryTrigger && ach17MemoryCode != 00017)
        {
            StartCoroutine(Trigger17MemoryAch());
        }

        ach18MemoryCode = PlayerPrefs.GetInt("Ach18Memory");
        if (ach18MemoryCount > ach18MemoryTrigger && ach18MemoryCode != 00018)
        {
            StartCoroutine(Trigger18MemoryAch());
        }

        ach19MemoryCode = PlayerPrefs.GetInt("Ach19Memory");
        if (ach19MemoryCount > ach19MemoryTrigger && ach19MemoryCode != 00019)
        {
            StartCoroutine(Trigger19MemoryAch());
        }

        ach20MemoryCode = PlayerPrefs.GetInt("Ach20Memory");
        if (ach20MemoryCount > ach20MemoryTrigger && ach20MemoryCode != 00020)
        {
            StartCoroutine(Trigger20MemoryAch());
        }

        ach21MemoryCode = PlayerPrefs.GetInt("Ach21Memory");
        if (ach21MemoryCount > ach21MemoryTrigger && ach21MemoryCode != 00021)
        {
            StartCoroutine(Trigger21MemoryAch());
        }
    }

    IEnumerator TriggerFirstMemoryAch()
    {
        achActive = true;
        achFirstMemoryCode = 00001;
        PlayerPrefs.SetInt("AchFirstMemory", achFirstMemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger2MemoryAch()
    {
        achActive = true;
        ach2MemoryCode = 00002;
        PlayerPrefs.SetInt("Ach2Memory", ach2MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger3MemoryAch()
    {
        achActive = true;
        ach3MemoryCode = 00003;
        PlayerPrefs.SetInt("Ach3Memory", ach3MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger4MemoryAch()
    {
        achActive = true;
        ach4MemoryCode = 00004;
        PlayerPrefs.SetInt("Ach4Memory", ach4MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger5MemoryAch()
    {
        achActive = true;
        ach5MemoryCode = 00005;
        PlayerPrefs.SetInt("Ach5Memory", ach5MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger6MemoryAch()
    {
        achActive = true;
        ach6MemoryCode = 00006;
        PlayerPrefs.SetInt("Ach6Memory", ach6MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger7MemoryAch()
    {
        achActive = true;
        ach7MemoryCode = 00007;
        PlayerPrefs.SetInt("Ach7Memory", ach7MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger8MemoryAch()
    {
        achActive = true;
        ach8MemoryCode = 00008;
        PlayerPrefs.SetInt("Ach8Memory", ach8MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger9MemoryAch()
    {
        achActive = true;
        ach9MemoryCode = 00009;
        PlayerPrefs.SetInt("Ach9Memory", ach9MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger10MemoryAch()
    {
        achActive = true;
        ach10MemoryCode = 00010;
        PlayerPrefs.SetInt("Ach10Memory", ach10MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger11MemoryAch()
    {
        achActive = true;
        ach11MemoryCode = 00011;
        PlayerPrefs.SetInt("Ach11Memory", ach11MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger12MemoryAch()
    {
        achActive = true;
        ach12MemoryCode = 00012;
        PlayerPrefs.SetInt("Ach12Memory", ach12MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger13MemoryAch()
    {
        achActive = true;
        ach13MemoryCode = 00013;
        PlayerPrefs.SetInt("Ach13Memory", ach13MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger14MemoryAch()
    {
        achActive = true;
        ach14MemoryCode = 00014;
        PlayerPrefs.SetInt("Ach14Memory", ach14MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger15MemoryAch()
    {
        achActive = true;
        ach15MemoryCode = 00015;
        PlayerPrefs.SetInt("Ach15Memory", ach15MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger16MemoryAch()
    {
        achActive = true;
        ach16MemoryCode = 00016;
        PlayerPrefs.SetInt("Ach16Memory", ach16MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger17MemoryAch()
    {
        achActive = true;
        ach17MemoryCode = 00017;
        PlayerPrefs.SetInt("Ach17Memory", ach17MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger18MemoryAch()
    {
        achActive = true;
        ach18MemoryCode = 00018;
        PlayerPrefs.SetInt("Ach18Memory", ach18MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger19MemoryAch()
    {
        achActive = true;
        ach19MemoryCode = 00019;
        PlayerPrefs.SetInt("Ach19Memory", ach19MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger20MemoryAch()
    {
        achActive = true;
        ach20MemoryCode = 00020;
        PlayerPrefs.SetInt("Ach20Memory", ach20MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }

    IEnumerator Trigger21MemoryAch()
    {
        achActive = true;
        ach21MemoryCode = 00021;
        PlayerPrefs.SetInt("Ach21Memory", ach21MemoryCode);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(1);
        achActive = false;
    }
}
