using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Shoot : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public static bool SisPressed = false;


    // Update is called once per frame
    void Update()
    {
       

    }

    public void OnPointerDown(PointerEventData eventData)
    {
       SisPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SisPressed = false;
    }



}

