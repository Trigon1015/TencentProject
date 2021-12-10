using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class change1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool world = false;


    // Update is called once per frame
    void Update()
    {
       

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        world = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        world = false;
    }



}

