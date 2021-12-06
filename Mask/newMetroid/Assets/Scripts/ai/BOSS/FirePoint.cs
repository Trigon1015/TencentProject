using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    public UnityEngine.Transform BossFirepoint;
    public GameObject bulletright1;
    public GameObject bulletright2;
    public GameObject bulletright3;
    public GameObject bulletleft1;
    public GameObject bulletleft2;
    public GameObject bulletleft3;
    public static float attackSpeed = 2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BossThrowState.attack == true)
        {
            attackSpeed -= Time.deltaTime;

            if (attackSpeed <= 0)
            {

                attack();
               
                attackSpeed = 2;
            }

        }
        else attackSpeed = 2;
        
    }
    private void attack()
    {
        if (BOSSFSM.right == false)
        {
            Instantiate(bulletleft1, BossFirepoint.position, BossFirepoint.rotation);
            Instantiate(bulletleft2, BossFirepoint.position, BossFirepoint.rotation);
            Instantiate(bulletleft3, BossFirepoint.position, BossFirepoint.rotation);
           
        }
        else
        {
            Instantiate(bulletright1, BossFirepoint.position, BossFirepoint.rotation);
            Instantiate(bulletright2, BossFirepoint.position, BossFirepoint.rotation);
            Instantiate(bulletright3, BossFirepoint.position, BossFirepoint.rotation);

        }
    }
}
