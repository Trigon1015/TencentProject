using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool LisPressed = false;


    // Update is called once per frame
    void Update()
    {
        
        if (LisPressed)
        {
            PlayerController.InputDirection = -1;
        }
        else if(!LisPressed&& !Right.RisPressed)
        {
            PlayerController.InputDirection = 0;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        LisPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        LisPressed = false;
    }
}

