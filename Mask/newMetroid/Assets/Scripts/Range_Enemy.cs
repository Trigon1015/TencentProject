using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range_Enemy : MonoBehaviour
{
    public GameObject bulletPrefabs1;
    public UnityEngine.Transform FirePoints;
    public static float ShieldHP = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    private void fireBullet()
    {
        Instantiate(bulletPrefabs1, FirePoints.position, FirePoints.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet BLUE")
        {
            Destroy(gameObject);
        }
    }
}
