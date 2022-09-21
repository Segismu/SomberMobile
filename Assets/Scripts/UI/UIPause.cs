using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPause : MonoBehaviour
{
    [SerializeField] Canvas pauseMenuCanvas;
    bool isPaused = false;

    void Awake()
    {
        pauseMenuCanvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && isPaused == false)
        {
            isPaused = true;
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.P) && isPaused == true)
        {
            isPaused = false;
            ContinueGame();
        }

    }

    void PauseGame()
    {
        pauseMenuCanvas.enabled = true;
        PauseService.Pause();
    }

    void ContinueGame()
    {
        pauseMenuCanvas.enabled = false;
        PauseService.UnPause();
    }
}
