using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3Weapon : MonoBehaviour
{
    public UnityEngine.Transform lightpoint;
    public UnityEngine.Transform lightpoint2;
    public GameObject Prefabs;
   
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Prefabs, lightpoint.position, lightpoint.rotation);
        if (Boss3ChaseState.up  == true)
        {
            Instantiate(Prefabs, lightpoint.position, lightpoint.rotation);
            time += Time.deltaTime;
            if (time >= 1.99999)
            {
                Instantiate(Prefabs, lightpoint.position, lightpoint.rotation);
                time = 0;
            }


        }
    }
}
