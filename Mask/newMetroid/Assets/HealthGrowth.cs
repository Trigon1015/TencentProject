using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGrowth : MonoBehaviour
{
    public ParticleSystem upgradeEffects;
    public Transform playerPosition;

    void Start()
    {

        playerPosition = GameObject.Find("Player 1").transform;
        if (PlayerManager.PlayerHP == 6f)
        {
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerManager.PlayerHP = 6f;
            Instantiate(upgradeEffects, playerPosition);
            Destroy(gameObject);
        }
    }
}
