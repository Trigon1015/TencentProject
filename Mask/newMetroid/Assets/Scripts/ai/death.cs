using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public static bool dead = false;
    public GameObject bossdead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dead ==true)
        {
            Instantiate(bossdead, transform.position, transform.rotation);
            dead = false;
            
            gameObject.SetActive(false);
        }
    }
}
