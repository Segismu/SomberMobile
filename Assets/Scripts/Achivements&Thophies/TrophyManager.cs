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
    }
}
