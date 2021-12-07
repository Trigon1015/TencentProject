using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public static health instance;
    public GameObject healthBar;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void Update()
    {

        switch (PlayerManager.PlayerMaxHP)
        {
            case 5:
                healthBar.transform.GetChild(0).gameObject.SetActive(true);
                healthBar.transform.GetChild(1).gameObject.SetActive(true);
                healthBar.transform.GetChild(2).gameObject.SetActive(true);
                healthBar.transform.GetChild(3).gameObject.SetActive(true);
                healthBar.transform.GetChild(4).gameObject.SetActive(true);
                break;
            case 6:
                healthBar.transform.GetChild(0).gameObject.SetActive(true);
                healthBar.transform.GetChild(1).gameObject.SetActive(true);
                healthBar.transform.GetChild(2).gameObject.SetActive(true);
                healthBar.transform.GetChild(3).gameObject.SetActive(true);
                healthBar.transform.GetChild(4).gameObject.SetActive(true);
                healthBar.transform.GetChild(5).gameObject.SetActive(true);
                break;
        }
        if (PlayerManager.PlayerMaxHP == 6)
        {
            switch (PlayerManager.PlayerHP)
            {
                case 6:
                    healthBar.transform.GetChild(0).gameObject.SetActive(true);
                    healthBar.transform.GetChild(1).gameObject.SetActive(true);
                    healthBar.transform.GetChild(2).gameObject.SetActive(true);
                    healthBar.transform.GetChild(3).gameObject.SetActive(true);
                    healthBar.transform.GetChild(4).gameObject.SetActive(true);
                    healthBar.transform.GetChild(5).gameObject.SetActive(true);
                    healthBar.transform.GetChild(6).gameObject.SetActive(false);
                    healthBar.transform.GetChild(7).gameObject.SetActive(false);
                    healthBar.transform.GetChild(8).gameObject.SetActive(false);
                    healthBar.transform.GetChild(9).gameObject.SetActive(false);
                    healthBar.transform.GetChild(10).gameObject.SetActive(false);
                    healthBar.transform.GetChild(11).gameObject.SetActive(false);
                    break;
                case 5:
                    healthBar.transform.GetChild(0).gameObject.SetActive(true);
                    healthBar.transform.GetChild(1).gameObject.SetActive(true);
                    healthBar.transform.GetChild(2).gameObject.SetActive(true);
                    healthBar.transform.GetChild(3).gameObject.SetActive(true);
                    healthBar.transform.GetChild(4).gameObject.SetActive(true);
                    healthBar.transform.GetChild(5).gameObject.SetActive(false);
                    healthBar.transform.GetChild(6).gameObject.SetActive(false);
                    healthBar.transform.GetChild(7).gameObject.SetActive(false);
                    healthBar.transform.GetChild(8).gameObject.SetActive(false);
                    healthBar.transform.GetChild(9).gameObject.SetActive(false);
                    healthBar.transform.GetChild(10).gameObject.SetActive(false);
                    healthBar.transform.GetChild(11).gameObject.SetActive(true);
                    break;
                case 4:
                    healthBar.transform.GetChild(0).gameObject.SetActive(true);
                    healthBar.transform.GetChild(1).gameObject.SetActive(true);
                    healthBar.transform.GetChild(2).gameObject.SetActive(true);
                    healthBar.transform.GetChild(3).gameObject.SetActive(true);
                    healthBar.transform.GetChild(4).gameObject.SetActive(false);
                    healthBar.transform.GetChild(5).gameObject.SetActive(false);
                    healthBar.transform.GetChild(6).gameObject.SetActive(false);
                    healthBar.transform.GetChild(7).gameObject.SetActive(false);
                    healthBar.transform.GetChild(8).gameObject.SetActive(false);
                    healthBar.transform.GetChild(9).gameObject.SetActive(false);
                    healthBar.transform.GetChild(10).gameObject.SetActive(true);
                    healthBar.transform.GetChild(11).gameObject.SetActive(true);
                    break;
                case 3:
                    healthBar.transform.GetChild(0).gameObject.SetActive(true);
                    healthBar.transform.GetChild(1).gameObject.SetActive(true);
                    healthBar.transform.GetChild(2).gameObject.SetActive(true);
                    healthBar.transform.GetChild(3).gameObject.SetActive(false);
                    healthBar.transform.GetChild(4).gameObject.SetActive(false);
                    healthBar.transform.GetChild(5).gameObject.SetActive(false);
                    healthBar.transform.GetChild(6).gameObject.SetActive(false);
                    healthBar.transform.GetChild(7).gameObject.SetActive(false);
                    healthBar.transform.GetChild(8).gameObject.SetActive(false);
                    healthBar.transform.GetChild(9).gameObject.SetActive(true);
                    healthBar.transform.GetChild(10).gameObject.SetActive(true);
                    healthBar.transform.GetChild(11).gameObject.SetActive(true);
                    break;
                case 2:
                    healthBar.transform.GetChild(0).gameObject.SetActive(true);
                    healthBar.transform.GetChild(1).gameObject.SetActive(true);
                    healthBar.transform.GetChild(2).gameObject.SetActive(false);
                    healthBar.transform.GetChild(3).gameObject.SetActive(false);
                    healthBar.transform.GetChild(4).gameObject.SetActive(false);
                    healthBar.transform.GetChild(5).gameObject.SetActive(false);
                    healthBar.transform.GetChild(6).gameObject.SetActive(false);
                    healthBar.transform.GetChild(7).gameObject.SetActive(false);
                    healthBar.transform.GetChild(8).gameObject.SetActive(true);
                    healthBar.transform.GetChild(9).gameObject.SetActive(true);
                    healthBar.transform.GetChild(10).gameObject.SetActive(true);
                    healthBar.transform.GetChild(11).gameObject.SetActive(true);
                    break;
                case 1:
                    healthBar.transform.GetChild(0).gameObject.SetActive(true);
                    healthBar.transform.GetChild(1).gameObject.SetActive(false);
                    healthBar.transform.GetChild(2).gameObject.SetActive(false);
                    healthBar.transform.GetChild(3).gameObject.SetActive(false);
                    healthBar.transform.GetChild(4).gameObject.SetActive(false);
                    healthBar.transform.GetChild(5).gameObject.SetActive(false);
                    healthBar.transform.GetChild(6).gameObject.SetActive(false);
                    healthBar.transform.GetChild(7).gameObject.SetActive(true);
                    healthBar.transform.GetChild(8).gameObject.SetActive(true);
                    healthBar.transform.GetChild(9).gameObject.SetActive(true);
                    healthBar.transform.GetChild(10).gameObject.SetActive(true);
                    healthBar.transform.GetChild(11).gameObject.SetActive(true);
                    break;

                case 0:
                    healthBar.transform.GetChild(0).gameObject.SetActive(false);
                    healthBar.transform.GetChild(1).gameObject.SetActive(false);
                    healthBar.transform.GetChild(2).gameObject.SetActive(false);
                    healthBar.transform.GetChild(3).gameObject.SetActive(false);
                    healthBar.transform.GetChild(4).gameObject.SetActive(false);
                    healthBar.transform.GetChild(5).gameObject.SetActive(false);
                    healthBar.transform.GetChild(6).gameObject.SetActive(true);
                    healthBar.transform.GetChild(7).gameObject.SetActive(true);
                    healthBar.transform.GetChild(8).gameObject.SetActive(true);
                    healthBar.transform.GetChild(9).gameObject.SetActive(true);
                    healthBar.transform.GetChild(10).gameObject.SetActive(true);
                    healthBar.transform.GetChild(11).gameObject.SetActive(true);
                    break;
            }
        }
            if (PlayerManager.PlayerMaxHP == 5)
        {
            switch (PlayerManager.PlayerHP)
                {
               
                    case 5:
                        healthBar.transform.GetChild(0).gameObject.SetActive(true);
                        healthBar.transform.GetChild(1).gameObject.SetActive(true);
                        healthBar.transform.GetChild(2).gameObject.SetActive(true);
                        healthBar.transform.GetChild(3).gameObject.SetActive(true);
                        healthBar.transform.GetChild(4).gameObject.SetActive(true);
                        healthBar.transform.GetChild(5).gameObject.SetActive(false);
                        healthBar.transform.GetChild(6).gameObject.SetActive(false);
                        healthBar.transform.GetChild(7).gameObject.SetActive(false);
                        healthBar.transform.GetChild(8).gameObject.SetActive(false);
                        healthBar.transform.GetChild(9).gameObject.SetActive(false);
                        healthBar.transform.GetChild(10).gameObject.SetActive(false);
                        healthBar.transform.GetChild(11).gameObject.SetActive(false);
                        break;
                    case 4:
                        healthBar.transform.GetChild(0).gameObject.SetActive(true);
                        healthBar.transform.GetChild(1).gameObject.SetActive(true);
                        healthBar.transform.GetChild(2).gameObject.SetActive(true);
                        healthBar.transform.GetChild(3).gameObject.SetActive(true);
                        healthBar.transform.GetChild(4).gameObject.SetActive(false);
                        healthBar.transform.GetChild(5).gameObject.SetActive(false);
                        healthBar.transform.GetChild(6).gameObject.SetActive(false);
                        healthBar.transform.GetChild(7).gameObject.SetActive(false);
                        healthBar.transform.GetChild(8).gameObject.SetActive(false);
                        healthBar.transform.GetChild(9).gameObject.SetActive(false);
                        healthBar.transform.GetChild(10).gameObject.SetActive(true);
                        healthBar.transform.GetChild(11).gameObject.SetActive(false);
                        break;
                    case 3:
                        healthBar.transform.GetChild(0).gameObject.SetActive(true);
                        healthBar.transform.GetChild(1).gameObject.SetActive(true);
                        healthBar.transform.GetChild(2).gameObject.SetActive(true);
                        healthBar.transform.GetChild(3).gameObject.SetActive(false);
                        healthBar.transform.GetChild(4).gameObject.SetActive(false);
                        healthBar.transform.GetChild(5).gameObject.SetActive(false);
                        healthBar.transform.GetChild(6).gameObject.SetActive(false);
                        healthBar.transform.GetChild(7).gameObject.SetActive(false);
                        healthBar.transform.GetChild(8).gameObject.SetActive(false);
                        healthBar.transform.GetChild(9).gameObject.SetActive(true);
                        healthBar.transform.GetChild(10).gameObject.SetActive(true);
                        healthBar.transform.GetChild(11).gameObject.SetActive(false);
                        break;
                    case 2:
                        healthBar.transform.GetChild(0).gameObject.SetActive(true);
                        healthBar.transform.GetChild(1).gameObject.SetActive(true);
                        healthBar.transform.GetChild(2).gameObject.SetActive(false);
                        healthBar.transform.GetChild(3).gameObject.SetActive(false);
                        healthBar.transform.GetChild(4).gameObject.SetActive(false);
                        healthBar.transform.GetChild(5).gameObject.SetActive(false);
                        healthBar.transform.GetChild(6).gameObject.SetActive(false);
                        healthBar.transform.GetChild(7).gameObject.SetActive(false);
                        healthBar.transform.GetChild(8).gameObject.SetActive(true);
                        healthBar.transform.GetChild(9).gameObject.SetActive(true);
                        healthBar.transform.GetChild(10).gameObject.SetActive(true);
                        healthBar.transform.GetChild(11).gameObject.SetActive(false);
                        break;
                    case 1:
                        healthBar.transform.GetChild(0).gameObject.SetActive(true);
                        healthBar.transform.GetChild(1).gameObject.SetActive(false);
                        healthBar.transform.GetChild(2).gameObject.SetActive(false);
                        healthBar.transform.GetChild(3).gameObject.SetActive(false);
                        healthBar.transform.GetChild(4).gameObject.SetActive(false);
                        healthBar.transform.GetChild(5).gameObject.SetActive(false);
                        healthBar.transform.GetChild(6).gameObject.SetActive(false);
                        healthBar.transform.GetChild(7).gameObject.SetActive(true);
                        healthBar.transform.GetChild(8).gameObject.SetActive(true);
                        healthBar.transform.GetChild(9).gameObject.SetActive(true);
                        healthBar.transform.GetChild(10).gameObject.SetActive(true);
                        healthBar.transform.GetChild(11).gameObject.SetActive(false);
                        break;

                    case 0:
                        healthBar.transform.GetChild(0).gameObject.SetActive(false);
                        healthBar.transform.GetChild(1).gameObject.SetActive(false);
                        healthBar.transform.GetChild(2).gameObject.SetActive(false);
                        healthBar.transform.GetChild(3).gameObject.SetActive(false);
                        healthBar.transform.GetChild(4).gameObject.SetActive(false);
                        healthBar.transform.GetChild(5).gameObject.SetActive(false);
                        healthBar.transform.GetChild(6).gameObject.SetActive(true);
                        healthBar.transform.GetChild(7).gameObject.SetActive(true);
                        healthBar.transform.GetChild(8).gameObject.SetActive(true);
                        healthBar.transform.GetChild(9).gameObject.SetActive(true);
                        healthBar.transform.GetChild(10).gameObject.SetActive(true);
                        healthBar.transform.GetChild(11).gameObject.SetActive(false);
                        break;
                }



            }
        
    }
}