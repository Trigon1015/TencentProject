using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{


    public static PlayerManager instance;
    public static Vector3 postion;
    

    //player attribute
    public static float PlayerHP = 5f;
    public static float PlayerMaxHP = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        if (instance != null)
        {
            
            Destroy(gameObject);

        }
        else
        {
            
            instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerHP--;
        }
            if (UiManager.isload ==false )
        {
            postion = this.transform.position;

        }
        else
        {
            this.transform.position=postion ;
            UiManager.isload = false;
        }
       // Debug.Log(postion);
    }




}
