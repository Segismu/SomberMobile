using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOMBER.Dialogue;
using TMPro;
using UnityEngine.UI;

namespace SOMBER.UI
{
    public class DialogueUI : MonoBehaviour
    {
        PlayerConversant playerConversant;
        [SerializeField] TextMeshProUGUI AIText;
        [SerializeField] Button nextButton;
        
        void Start()
        {
            playerConversant = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerConversant>();
            playerConversant.onConversationUpdated += UpdateUI;
            nextButton.onClick.AddListener(Next);

            UpdateUI();
        }

        void Next()
        {
            playerConversant.Next();
        }

        void UpdateUI()
        {
            if (!playerConversant.IsActive())
            {
                return;
            }

            AIText.text = playerConversant.GetText();
            nextButton.gameObject.SetActive(playerConversant.HasNext());
        }
    }
}
