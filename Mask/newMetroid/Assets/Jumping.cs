using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Jumping : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool JisPressed = false;
    


    // Update is called once per frame
    void Update()
    {


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
         JisPressed = true;
            
        
       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        JisPressed = false;
    }
}
