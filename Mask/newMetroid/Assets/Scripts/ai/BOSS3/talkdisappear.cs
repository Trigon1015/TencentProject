using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkdisappear : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    private void Update()
    {
        time += Time.deltaTime;
        if (time >= 2)
        {
            Destroy(gameObject);
        }
    }
}
