using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    public GameObject enemy;
    public UnityEngine.Transform point;
    public bool active=true;
    public bool active1 = true;
    public bool active2 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Boss2ChaseState.hp <=9&&active==true )
        {
            Instantiate(enemy, point.position, point.rotation);
            active = false;
        }
        if (Boss2ChaseState.hp <= 6 && active1 == true)
        {
            Instantiate(enemy, point.position, point.rotation);
            active1 = false;
        }
        if (Boss2ChaseState.hp <= 3 && active2 == true)
        {
            Instantiate(enemy, point.position, point.rotation);
            active2 = false;
        }
    }
}
