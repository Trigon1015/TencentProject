using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Down : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool DisPressed = false;
    public static bool Small = false;
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 1f;

    // Update is called once per frame
    void Update()
    {
        

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        
        if(!DisPressed)
        {
            DisPressed = true;
        }
        clicked++;
        if (clicked == 1) clicktime = Time.time;

        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            Small = true;
            Debug.Log("Double CLick: " + this.GetComponent<RectTransform>().name);

        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;






    }

    public void OnPointerUp(PointerEventData eventData)
    {
        DisPressed = false;
        Small = false;
    }
}
