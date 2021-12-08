using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    // Start is called before the first frame update
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Boss3Enemy.health--;
        }
        if (collision.tag == "Player")
        {
            PlayerManager.PlayerHP--;
        }
    }
    
}
