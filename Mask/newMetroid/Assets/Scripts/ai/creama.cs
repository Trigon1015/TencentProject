using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creama : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Boss2ChaseState.change == 1 && ChangeWorld.active == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, -16, 0);

            ChangeWorld.active = true;

        }
        if (Boss2ChaseState.change == 2 && ChangeWorld.active2 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, -16, 0);

            ChangeWorld.active2 = true;

        }
        if (Boss2ChaseState.change == 3 && ChangeWorld.active3 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, -16, 0);

            ChangeWorld.active3 = true;

        }
        if (Boss2EnemyState.back == 4 && ChangeWorld.active4 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, 22, 0);

            ChangeWorld.active4 = true;

        }
        if (Boss2EnemyState.back == 5 && ChangeWorld.active5 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, 22, 0);

            ChangeWorld.active5 = true;

        }
        if (Boss2EnemyState.back == 6 && ChangeWorld.active6 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, 22, 0);

            ChangeWorld.active6 = true;

        }
    }
}
