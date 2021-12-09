using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3Weapon : MonoBehaviour
{
    public UnityEngine.Transform lightpoint;
    public UnityEngine.Transform lightpoint2;
    public UnityEngine.Transform lightpoint3;
    public UnityEngine.Transform lightpoint4;
    public UnityEngine.Transform lightpoint5;
    public UnityEngine.Transform lightpoint6;
    public UnityEngine.Transform lightpoint7;
    public UnityEngine.Transform lightpoint8;
    public GameObject Prefabs;
    public GameObject warn;
    public bool activate= true;
    public bool activate2= true;


    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(time);
        if (Boss3ChaseState.up  == true)
        {time += Time.deltaTime;
           if (time>=0&&activate ==true)
            {
                Instantiate(warn, lightpoint.position, lightpoint.rotation);
                activate =false;
            }
            
            if (time >= 2&&activate2==true )
            {
                Instantiate(Prefabs, lightpoint.position, lightpoint.rotation);
                activate2 = false;
            }
            if(time>=3.9999)
            {
                time = 0; Boss3ChaseState.up =false;
                activate = true; activate2 = true;
               
            }
            


        }
        if (Boss3ChargeState.down == true)
        {
          
            time += Time.deltaTime;
            if (time >= 0 && activate == true)
            {
                Instantiate(warn, lightpoint2.position, lightpoint2.rotation); activate = false;
            }
            if (time >= 2 && activate2 == true)
            {
                Instantiate(Prefabs, lightpoint2.position, lightpoint2.rotation);
                activate2 = false;
            }
            if (time >= 3.999)
            {
                time = 0;Boss3ChargeState.down = false;
                activate = true; activate2 = true;
                
            }


        }
        if (Boss3ThrowState.right == true)
        {

            time += Time.deltaTime;
            if (time >= 0 && activate == true)
            {
                Instantiate(warn, lightpoint3.position, lightpoint3.rotation);
                Instantiate(warn, lightpoint4.position, lightpoint4.rotation);
                Instantiate(warn, lightpoint5.position, lightpoint5.rotation);
                Instantiate(warn, lightpoint6.position, lightpoint6.rotation);
                Instantiate(warn, lightpoint7.position, lightpoint7.rotation);
                Instantiate(warn, lightpoint8.position, lightpoint8.rotation); activate = false;

            }
            if (time >= 2 && activate2 == true)
            {
                Instantiate(Prefabs, lightpoint3.position, lightpoint3.rotation);
                Instantiate(Prefabs, lightpoint4.position, lightpoint4.rotation);
                Instantiate(Prefabs, lightpoint5.position, lightpoint5.rotation);
                Instantiate(Prefabs, lightpoint6.position, lightpoint6.rotation);
                Instantiate(Prefabs, lightpoint7.position, lightpoint7.rotation);
                Instantiate(Prefabs, lightpoint8.position, lightpoint8.rotation);
                activate2 = false;
            }
            if (time >= 3.999)
            {
                time = 0;Boss3ThrowState.right = false;
                activate = true; activate2 = true;
                
            }


        }
    }
}
