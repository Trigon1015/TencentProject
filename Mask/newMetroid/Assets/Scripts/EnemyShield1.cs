using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShield1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Range_Enemy.ShieldHP<=0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet BLUE")
        {
            Range_Enemy.ShieldHP--;
        }
    }
}
