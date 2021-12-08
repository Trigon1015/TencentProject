using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    public GameObject enemy;
    public UnityEngine.Transform point;
    public UnityEngine.Transform point2;
    public UnityEngine.Transform point3;
    public UnityEngine.Transform point4;
    public UnityEngine.Transform point5;
    public bool active = true;
    public bool active1 = true;
    public bool active2 = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Boss2ChaseState.hp <= 9 && active == true)
        {
            Instantiate(enemy, point.position, point.rotation);
            Instantiate(enemy, point2.position, point2.rotation);
            Instantiate(enemy, point3.position, point3.rotation);
            active = false;
        }
        if (Boss2ChaseState.hp <= 6 && active1 == true)
        {
            Instantiate(enemy, point.position, point.rotation);
            Instantiate(enemy, point2.position, point2.rotation);
            Instantiate(enemy, point3.position, point3.rotation);
            Instantiate(enemy, point4.position, point4.rotation);
            active1 = false;
        }
        if (Boss2ChaseState.hp <= 3 && active2 == true)
        {
            Instantiate(enemy, point.position, point.rotation);
            Instantiate(enemy, point2.position, point2.rotation);
            Instantiate(enemy, point3.position, point3.rotation);
            Instantiate(enemy, point4.position, point4.rotation);
            Instantiate(enemy, point5.position, point5.rotation);
            active2 = false;
        }
    }
}
