using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool CanSamll=true ;

    private void OnTriggerStay2D(Collider2D collision)
    {
        CanSamll = false;
        Debug.Log("cannot");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CanSamll = true;
        Debug.Log("can");
    }
}
