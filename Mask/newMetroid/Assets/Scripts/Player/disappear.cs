using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public GameObject change;
    public GameObject gravity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeWorld.change == 1)
        {

            change.SetActive(true);
        }
        if (ChangeWorld.change == 0)
        {

            change.SetActive(false);
        }

    }
}
