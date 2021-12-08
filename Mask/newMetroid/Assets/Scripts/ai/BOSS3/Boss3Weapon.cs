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
   
    public float time = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = 2;
        if (Boss3ChaseState.up  == true)
        {
           
            time += Time.deltaTime;
            if (time >= 1.99999)
            {
                Instantiate(Prefabs, lightpoint.position, lightpoint.rotation);
                time = 0;
            }


        }
        if (Boss3ChargeState.down == true)
        {
          
            time += Time.deltaTime;
            if (time >= 1.99999)
            {
                Instantiate(Prefabs, lightpoint2.position, lightpoint2.rotation);
                time = 0;
            }


        }
        if (Boss3ThrowState.right == true)
        {

            time += Time.deltaTime;
            if (time >= 1.99999)
            {
                Instantiate(Prefabs, lightpoint3.position, lightpoint3.rotation);
                Instantiate(Prefabs, lightpoint4.position, lightpoint4.rotation);
                Instantiate(Prefabs, lightpoint5.position, lightpoint5.rotation);
                Instantiate(Prefabs, lightpoint6.position, lightpoint6.rotation);
                Instantiate(Prefabs, lightpoint7.position, lightpoint7.rotation);
                Instantiate(Prefabs, lightpoint8.position, lightpoint8.rotation);
                time = 0;
            }


        }
    }
}
