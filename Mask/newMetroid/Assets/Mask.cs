using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Mask : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool MisPressed = false;



    // Update is called once per frame
    void Update()
    {
        if(!PlayerController.MaskH)
        {
            MisPressed = false;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {

        MisPressed = true;
        PlayerController.MaskH = true;



    }

    public void OnPointerUp(PointerEventData eventData)
    {
        MisPressed = false;
    }
}

