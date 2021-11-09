using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkPerson : MonoBehaviour
{
    public GameObject NPC;
    private float time;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && PlayerController.isTalking == true)
        {
            NPC.SetActive(true);

        }
        else
            NPC.SetActive(false);
    }

}
