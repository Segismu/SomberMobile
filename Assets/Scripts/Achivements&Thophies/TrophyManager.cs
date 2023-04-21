using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyManager : MonoBehaviour
{
    //Needs to expand for each achivement.

    public GameObject firstMemoryTrophy;
    public int achFirstMemoryCode;

    void Start()
    {
        firstMemoryTrophy.SetActive(false);
    }

    void Update()
    {
        achFirstMemoryCode = PlayerPrefs.GetInt("AchFirstMemory");

        if (achFirstMemoryCode == 00001)
        {
            firstMemoryTrophy.SetActive(true);
        }
    }
}
