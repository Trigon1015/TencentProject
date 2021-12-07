using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool RisPressed = false;
    

    // Update is called once per frame
    void Update()
    {
        if(RisPressed)
        {
            PlayerController.InputDirection = 1;
        }
        else if (!Left.LisPressed && !RisPressed)
        {
            
            PlayerController.InputDirection = 0;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        RisPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        RisPressed = false;
    }
}
