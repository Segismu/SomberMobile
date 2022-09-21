
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PauseService
{
    public static void Pause()
    {
        Time.timeScale = 0;
    }

    public static void UnPause()
    {
        Time.timeScale = 1;
    }
}