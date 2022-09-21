using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyHolder : MonoBehaviour
{
    [SerializeField] private KeyHolder keyHolder;

    private Transform container;
    private Transform keyTemplate;

    private void Awake()
    {
        container = transform.Find("container");
        keyTemplate = container.Find("keyTemplate");
        keyTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        keyHolder.OnKeysChanged += KeyHolder_OnKeysChanged;
    }

    private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e)
    {
        UpdateUIKey();
    }

    private void UpdateUIKey()
    {
        //Quita llaves viejas.
        foreach(Transform child in container)
        {
            if (child == keyTemplate) continue;
            Destroy(child.gameObject);
            keyTemplate.gameObject.SetActive(false);
        }

        //Instancia llaves nuevas.
        List<Key.KeyType> keyList = keyHolder.GetKeyList();
        for (int i = 0; i < keyList.Count; i++)
        {
            Key.KeyType keyType = keyList[i];
            Transform keytransform = Instantiate(keyTemplate, container);
            keyTemplate.gameObject.SetActive(true);
            keytransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(-125 * i, 0);
            Image keyImage = keytransform.Find("image").GetComponent<Image>();

            switch (keyType)
            {
                default:
                case Key.KeyType.Orange:keyImage.color = Color.clear; break;
            }
        }
    }
}
