using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class gravity : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    public static bool ni = false;
    public static int chen = 0;


    // Update is called once per frame
    void Update()
    {


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ni = true;
        chen++;
        Debug.Log(ni);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ni = false;
    }
}
