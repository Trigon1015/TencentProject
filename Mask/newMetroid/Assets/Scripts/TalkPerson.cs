using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkPerson : MonoBehaviour
{
    public GameObject NPC;
    //public Dialogue dialogue;
    public void OnTriggerStay2D(Collider2D collider)
    {Debug.Log("1");
       
        if (collider.tag=="Player" && PlayerController.isTalking == true)
        {
            //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            NPC.SetActive(true);

        }
        else
           NPC.SetActive(false);
    }

}
