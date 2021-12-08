using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public float time;
    private void Update()
    {
        time += Time.deltaTime;
        if (time>=2)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D info)
    {


        if (info.gameObject.tag == "Player")
        {
            PlayerManager.PlayerHP--;
            //Debug.Log("HP"+PlayerManager.PlayerHP);


            

        }
    }
}
