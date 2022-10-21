using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SOMBER.Dialogue
{
    public class ProximityDialogue : MonoBehaviour
    {
        [SerializeField] Dialogue dialogue = null;
        bool isReading = false;
        PlayerConversant playerConversant;

        void Awake() //Let's get the PlayersConversant
        {
            //The PlayerConversant is on the Player, not this GameObject, so we need to find the player
            //Then get the Player's PlayerConversant
            playerConversant = GameObject.FindWithTag("Player").GetComponent<PlayerConversant>();
        }

        void OnTriggerEnter(Collider Testis)
        {
            if (Testis.tag == "Player" && !isReading)
            {
                playerConversant.StartDialogue(dialogue);
                isReading = true;
            }

        }
    }
    }
