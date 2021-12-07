using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naillpail : MonoBehaviour
{
    public UnityEngine.Transform nailpoint;
    public UnityEngine.Transform pailpoint;
    public GameObject nailPrefabs;
    public GameObject pailPrefabs;
    public Transform nailpoint2;
    public Transform nailpoint3;
    public Transform nailpoint4;
    public Transform nailpoint5;
    public Transform pailpoints;
    public Transform pailpoint2;
    public Transform pailpoint3;

    public Transform pailpoint4;
    public Transform pailpoint5;
    public float time=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Boss2NailState.pail  == true)
        {
            
            time+= Time.deltaTime;
            if (time>=1.99999)
            {
                Instantiate(nailPrefabs, nailpoint.position, nailpoint.rotation);
                Instantiate(nailPrefabs, nailpoint2.position, nailpoint2.rotation);
                Instantiate(nailPrefabs, nailpoint3.position, nailpoint3.rotation);
                Instantiate(nailPrefabs, nailpoint4.position, nailpoint4.rotation);
                Instantiate(nailPrefabs, nailpoint5.position, nailpoint5.rotation);
                
                time = 0;
            }
            

        }
        if (Boss2ThrowState.nail  == true)
        {
            time += Time.deltaTime;
            if (time >= 1.99999)
            {
                Instantiate(pailPrefabs, pailpoint.position, pailpoint.rotation);
                Instantiate(pailPrefabs, pailpoint2.position, pailpoint2.rotation);
                Instantiate(pailPrefabs, pailpoint3.position, pailpoint3.rotation);

                Instantiate(pailPrefabs, pailpoint4.position, pailpoint4.rotation);
                Instantiate(pailPrefabs, pailpoint5.position, pailpoint5.rotation);
                time = 0;
            }

        }
    }
    
}
