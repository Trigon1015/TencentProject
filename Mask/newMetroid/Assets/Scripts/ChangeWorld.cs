using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWorld : MonoBehaviour
{
    public static bool canchange = false;
    public static bool active=false;
    public static bool active2 = false;
    public static bool active3 = false;
    public static bool active4 = false;
    public static bool active5 = false;
    public static bool active6 = false;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("check", 2.0f, 2f);

    }
   
     int i =1;//각것각것
     
    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(ChangeWorldCheck.changeworld);
        if (Boss2ChaseState.change ==1&&active==false)
        {
            
            //Debug.Log(i);
            
                transform.position += new Vector3(0, -16, 0);
            active = true;
           
        }
        if (Boss2ChaseState.change == 2 && active2 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, -16, 0);
            active2 = true;

        }
        if (Boss2ChaseState.change == 3 && active3 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, -16, 0);
            active3 = true;

        }
        if (Boss2EnemyState.back == 4 && active4 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, 22, 0);
            active4 = true;

        }
        if (Boss2EnemyState.back == 5 && active5 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, 22, 0);
            active5 = true;

        }
        if (Boss2EnemyState.back == 6 && active6 == false)
        {

            //Debug.Log(i);

            transform.position += new Vector3(0, 22, 0);
            active6 = true;

        }

        if (Input.GetKeyDown(KeyCode.L ) )
        {
            if (ChangeWorldCheck.ischanged == false)
            {
                //Debug.Log("Pressed");
                i++;
                //Debug.Log(i);
                if (i % 2 == 0)
                {
                    transform.position += new Vector3(0, -16, 0);
                }
                else
                {
                    transform.position += new Vector3(0, 16, 0);
                }
            }
        }

    }
    
}
