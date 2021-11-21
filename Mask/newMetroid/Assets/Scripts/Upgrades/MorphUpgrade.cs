using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorphUpgrade : MonoBehaviour
{
    public ParticleSystem upgradeEffects;
    public Transform playerPosition;

    void Start()
    {

        playerPosition = GameObject.Find("Player 1").transform;
        if(PlayerController.MorphUpgrade)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerController.MorphUpgrade = true;
            Instantiate(upgradeEffects, playerPosition);
            Destroy(gameObject);
        }
    }
}
