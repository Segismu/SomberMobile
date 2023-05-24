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

    void Start()
    {
        firstMemoryTrophy.SetActive(false);
        memory2Trophy.SetActive(false);
        memory3Trophy.SetActive(false);
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
    }
}
