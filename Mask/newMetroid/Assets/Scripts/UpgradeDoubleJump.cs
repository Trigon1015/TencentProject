using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  UpgradeDoubleJump: MonoBehaviour
{
    public ParticleSystem upgradeEffects;
    public Transform playerPosition;

    void Start()
    {

        playerPosition = GameObject.Find("Player 1").transform;

    }
    private void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            PlayerController.availableJumps = 2;
            Instantiate(upgradeEffects,playerPosition);
            Destroy(gameObject);
        }
    }
}
