using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Animator anim;
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject Impact;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        

    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D info)
    {
        if(info.gameObject.tag == "Environment")
        {
            Instantiate(Impact,transform.position,transform.rotation);
            Destroy(gameObject);
            
        }

        if(info.gameObject.tag == "Player")
        {
            PlayerManager.PlayerHP--;
            //Debug.Log("HP"+PlayerManager.PlayerHP);


            Instantiate(Impact, transform.position, transform.rotation);
            Destroy(gameObject);

        }

        if (info.gameObject.tag == "Shield")
        {

            Instantiate(Impact, transform.position, transform.rotation);
            Destroy(gameObject);

        }
       
        



    }
}
