using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pail : MonoBehaviour
{
    public AnimatorStateInfo time;
  
    public GameObject nail2;
    public Animator nail1;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        time = nail1.GetCurrentAnimatorStateInfo(0);
        if (time.normalizedTime >= .91)
        {
            nail2.tag = "Bullet";
            nail2.layer = 10;
            
        }
        if (time.normalizedTime >= .999)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D info)
    {


        if (info.gameObject.tag == "Player")
        {
            PlayerManager.PlayerHP--;
            //Debug.Log("HP"+PlayerManager.PlayerHP);



            

        }

        





    }
}

