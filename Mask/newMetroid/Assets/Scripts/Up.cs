using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Up : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool UisPressed = false;


    // Update is called once per frame
    void Update()
    {
       

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        UisPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        UisPressed = false;
    }
}

