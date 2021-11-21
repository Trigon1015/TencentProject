using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUpgrade : MonoBehaviour
{
    public ParticleSystem upgradeEffects;
    public Transform playerPosition;

    void Start()
    {

        playerPosition = GameObject.Find("Player 1").transform;
        if(PlayerController.MaskUpgrade)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            PlayerController.MaskUpgrade = true;
            Instantiate(upgradeEffects, playerPosition);
            Destroy(gameObject);
        }
    }
}
