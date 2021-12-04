using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range_Enemy : MonoBehaviour
{
    public GameObject bulletPrefabs1;
    public GameObject death;
    public UnityEngine.Transform FirePoints;
    public static float ShieldHP = 1;
    public float x1;
    public float y1;
    public Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x1 = transform.position.x - 1f;
        y1 = transform.position.y - 0.5f;
        myVector = new Vector3(x1, y1, transform.position.z);

    }

    private void fireBullet()
    {
        Instantiate(bulletPrefabs1, FirePoints.position, FirePoints.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet BLUE")
        {
            Instantiate(death, myVector, transform.rotation);
            Destroy(gameObject);
        }
    }
}
