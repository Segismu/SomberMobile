using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    [SerializeField] Canvas startMenuCanvas;


    void Awake()
    {
        startMenuCanvas.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Cerraste la aplicación");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



}
