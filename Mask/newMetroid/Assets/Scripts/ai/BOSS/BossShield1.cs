using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShield1 : MonoBehaviour
{
    public static bool Boss2=false ;
    public GameObject sheild;
    public float ShieldDurability = -10f;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BossBullet")
        {
            ShieldDurability -= 20f;
        }
    }
    private void Update()
    {
        if(ShieldDurability<=0)
        {
            Destroy(sheild );
            Boss2 = true;
        }
    }

}
