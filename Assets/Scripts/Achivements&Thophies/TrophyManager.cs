using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyManager : MonoBehaviour
{
    //Needs to expand for each achivement.

    public GameObject firstMemoryTrophy;
    int achFirstMemoryCode;

    public GameObject memory2Trophy;
    int ach2MemoryCode;

    public GameObject memory3Trophy;
    int ach3MemoryCode;

    public GameObject memory4Trophy;
    int ach4MemoryCode;

    public GameObject memory5Trophy;
    int ach5MemoryCode;

    public GameObject memory6Trophy;
    int ach6MemoryCode;

    public GameObject memory7Trophy;
    int ach7MemoryCode;

    public GameObject memory8Trophy;
    int ach8MemoryCode;

    public GameObject memory9Trophy;
    int ach9MemoryCode;

    public GameObject memory10Trophy;
    int ach10MemoryCode;

    public GameObject memory11Trophy;
    int ach11MemoryCode;

    public GameObject memory12Trophy;
    int ach12MemoryCode;

    public GameObject memory13Trophy;
    int ach13MemoryCode;

    public GameObject memory14Trophy;
    int ach14MemoryCode;

    public GameObject memory15Trophy;
    int ach15MemoryCode;

    public GameObject memory16Trophy;
    int ach16MemoryCode;

    public GameObject memory17Trophy;
    int ach17MemoryCode;

    public GameObject memory18Trophy;
    int ach18MemoryCode;

    public GameObject memory19Trophy;
    int ach19MemoryCode;

    public GameObject memory20Trophy;
    int ach20MemoryCode;

    public GameObject memory21Trophy;
    int ach21MemoryCode;

    void Start()
    {
        firstMemoryTrophy.SetActive(false);
        memory2Trophy.SetActive(false);
        memory3Trophy.SetActive(false);
        memory4Trophy.SetActive(false);
        memory5Trophy.SetActive(false);
        memory6Trophy.SetActive(false);
        memory7Trophy.SetActive(false);
        memory8Trophy.SetActive(false);
        memory9Trophy.SetActive(false);
        memory10Trophy.SetActive(false);
        memory11Trophy.SetActive(false);
        memory12Trophy.SetActive(false);
        memory13Trophy.SetActive(false);
        memory14Trophy.SetActive(false);
        memory15Trophy.SetActive(false);
        memory16Trophy.SetActive(false);
        memory17Trophy.SetActive(false);
        memory18Trophy.SetActive(false);
        memory19Trophy.SetActive(false);
        memory20Trophy.SetActive(false);
        memory21Trophy.SetActive(false);
    }

    void Update()
    {
        achFirstMemoryCode = PlayerPrefs.GetInt("AchFirstMemory");

        if (achFirstMemoryCode == 00001)
        {
            firstMemoryTrophy.SetActive(true);
        }

        ach2MemoryCode = PlayerPrefs.GetInt("Ach2Memory");

        if (ach2MemoryCode == 00002)
        {
            memory2Trophy.SetActive(true);
        }

        ach3MemoryCode = PlayerPrefs.GetInt("Ach3Memory");

        if (ach3MemoryCode == 00003)
        {
            memory3Trophy.SetActive(true);
        }

        ach4MemoryCode = PlayerPrefs.GetInt("Ach4Memory");

        if (ach4MemoryCode == 00004)
        {
            memory4Trophy.SetActive(true);
        }

        ach5MemoryCode = PlayerPrefs.GetInt("Ach5Memory");

        if (ach5MemoryCode == 00005)
        {
            memory5Trophy.SetActive(true);
        }

        ach6MemoryCode = PlayerPrefs.GetInt("Ach6Memory");

        if (ach6MemoryCode == 00006)
        {
            memory6Trophy.SetActive(true);
        }

        ach7MemoryCode = PlayerPrefs.GetInt("Ach7Memory");

        if (ach7MemoryCode == 00007)
        {
            memory7Trophy.SetActive(true);
        }

        ach8MemoryCode = PlayerPrefs.GetInt("Ach8Memory");

        if (ach8MemoryCode == 00008)
        {
            memory8Trophy.SetActive(true);
        }

        ach9MemoryCode = PlayerPrefs.GetInt("Ach9Memory");

        if (ach9MemoryCode == 00009)
        {
            memory9Trophy.SetActive(true);
        }

        ach10MemoryCode = PlayerPrefs.GetInt("Ach10Memory");

        if (ach10MemoryCode == 00010)
        {
            memory10Trophy.SetActive(true);
        }

        ach11MemoryCode = PlayerPrefs.GetInt("Ach11Memory");

        if (ach11MemoryCode == 00011)
        {
            memory11Trophy.SetActive(true);
        }

        ach12MemoryCode = PlayerPrefs.GetInt("Ach12Memory");

        if (ach12MemoryCode == 00012)
        {
            memory12Trophy.SetActive(true);
        }

        ach13MemoryCode = PlayerPrefs.GetInt("Ach13Memory");

        if (ach13MemoryCode == 00013)
        {
            memory13Trophy.SetActive(true);
        }

        ach14MemoryCode = PlayerPrefs.GetInt("Ach14Memory");

        if (ach14MemoryCode == 00014)
        {
            memory14Trophy.SetActive(true);
        }

        ach15MemoryCode = PlayerPrefs.GetInt("Ach15Memory");

        if (ach15MemoryCode == 00015)
        {
            memory15Trophy.SetActive(true);
        }

        ach16MemoryCode = PlayerPrefs.GetInt("Ach16Memory");

        if (ach16MemoryCode == 00016)
        {
            memory16Trophy.SetActive(true);
        }

        ach17MemoryCode = PlayerPrefs.GetInt("Ach17Memory");

        if (ach17MemoryCode == 00017)
        {
            memory17Trophy.SetActive(true);
        }

        ach18MemoryCode = PlayerPrefs.GetInt("Ach18Memory");

        if (ach18MemoryCode == 00018)
        {
            memory18Trophy.SetActive(true);
        }

        ach19MemoryCode = PlayerPrefs.GetInt("Ach19Memory");

        if (ach19MemoryCode == 00019)
        {
            memory19Trophy.SetActive(true);
        }

        ach20MemoryCode = PlayerPrefs.GetInt("Ach20Memory");

        if (ach20MemoryCode == 00020)
        {
            memory20Trophy.SetActive(true);
        }

        ach21MemoryCode = PlayerPrefs.GetInt("Ach21Memory");

        if (ach21MemoryCode == 00021)
        {
            memory21Trophy.SetActive(true);
        }
    }
}
