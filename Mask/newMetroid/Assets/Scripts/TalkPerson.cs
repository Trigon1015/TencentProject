using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkPerson : MonoBehaviour
{
    public GameObject NPC;
    
    public void OnTriggerStay2D(Collider2D collider)
    {Debug.Log("1");
       
        if (collider.tag=="Player" && PlayerController.isTalking == true)
        {
            
            NPC.SetActive(true);

        }
        else
            NPC.SetActive(false);
    }

}
