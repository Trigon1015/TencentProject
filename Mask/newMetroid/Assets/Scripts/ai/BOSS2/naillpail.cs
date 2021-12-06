using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naillpail : MonoBehaviour
{
    public UnityEngine.Transform nailpoint;
    public UnityEngine.Transform pailpoint;
    public GameObject nailPrefabs;
    public GameObject pailPrefabs;
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
                time = 0;
            }
            

        }
        if (Boss2ThrowState.nail  == true)
        {
            time += Time.deltaTime;
            if (time >= 1.99999)
            {
                Instantiate(pailPrefabs, pailpoint.position, pailpoint.rotation);
                time = 0;
            }

        }
    }
    
}
