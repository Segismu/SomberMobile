using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaKO : MonoBehaviour
{
    [SerializeField] AudioClip lavaKOSFX;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(lavaKOSFX);
        StartCoroutine(lavaKOED());
    }

    IEnumerator lavaKOED()
    {
        yield return new WaitForSeconds(1);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
