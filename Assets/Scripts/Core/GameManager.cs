using System.Collections;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [HideInInspector] public HPController hpManager;

    [SerializeField] private int DamageReceived;

    [SerializeField] ParticleSystem sucessParticles;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip crash;

    CinemachineImpulseSource impulse;

    float levelLoadDelay = 1.5f;

    AudioSource audioSource;

    [Header("immunityFrames")]
    [SerializeField] float iFramesDuration;
    [SerializeField] int nOfFlashes;

    Color baseColor;


    void Start()
    {
        Physics.IgnoreLayerCollision(3, 10, false);
        audioSource = GetComponent<AudioSource>();
        impulse = transform.GetComponent<CinemachineImpulseSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Obstacles":
                StartCrashSequence();
                break;
            case "Finish":
                StartSuccessSequence();
                break;
            default:
                break;
        }
    }

    void StartSuccessSequence()
    {
        audioSource.PlayOneShot(success);
        sucessParticles.Play();
        GetComponent<IsoCharacterController>().enabled = false;
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    void Shake()
    {
        impulse.GenerateImpulse();
    }

    void StartCrashSequence()
    {
        Invoke("Shake", 0f);
        audioSource.PlayOneShot(crash);
        crashParticles.Play();
        DamageDealer();
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    void DamageDealer()
    {
        hpManager.playerHP = hpManager.playerHP - DamageReceived;
        hpManager.UpdateHP();
        StartCoroutine(Invunerable());
    }

    public IEnumerator Invunerable()
    {
        Physics.IgnoreLayerCollision(3,10,true);

        for (int i = 0; i < nOfFlashes; i++)
        {
            yield return new WaitForSeconds(iFramesDuration / (nOfFlashes * 2));
        }

        Physics.IgnoreLayerCollision(3, 10,false);
    }

}

