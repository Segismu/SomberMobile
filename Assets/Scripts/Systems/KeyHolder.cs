using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyHolder : MonoBehaviour
{
    public event EventHandler OnKeysChanged;

    private List<Key.KeyType> keyList;

    [SerializeField] AudioClip getKeySFX;
    [SerializeField] AudioClip popGateSFX;

    AudioSource audioSource;

    private void Awake()
    {
        keyList = new List<Key.KeyType>();
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public List<Key.KeyType> GetKeyList()
    {
        return keyList;
    }

    public void AddKey(Key.KeyType keyType)
    {
        keyList.Add(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveKey(Key.KeyType keyType)
    {
        keyList.Remove(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool HasKey(Key.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider collider)
    {
        Key key = collider.GetComponent<Key>();
        if (key != null)
        {
            audioSource.PlayOneShot(getKeySFX);
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }

        KeyGate keyGate = collider.GetComponent<KeyGate>();
        if (keyGate != null)
        {
            if (HasKey(keyGate.GetKeyType()))
            {
                audioSource.PlayOneShot(popGateSFX);
                RemoveKey(keyGate.GetKeyType());
                keyGate.OpenGate();
            }
        }

    }
}
