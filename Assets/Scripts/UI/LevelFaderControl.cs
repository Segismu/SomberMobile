using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFaderControl : MonoBehaviour
{
    public Animator animator;
    public int levelToLoad;


    /* private void Awake()
    {
        int numFaders = FindObjectsOfType<LevelFaderControl>().Length;
        if (numFaders > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }*/

    public void FadeInNextLevel()
    {
        FadeInLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeInLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
