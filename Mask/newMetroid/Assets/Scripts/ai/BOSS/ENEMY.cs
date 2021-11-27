using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            //Debug.Log(PlayerManager.PlayerHP);
            PlayerManager.PlayerHP = PlayerManager.PlayerHP-1;
           // Debug.Log(PlayerManager.PlayerHP);
        }
    }
}
