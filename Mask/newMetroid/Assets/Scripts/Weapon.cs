using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public UnityEngine.Transform firepoint;
    public UnityEngine.Transform crouchfirepoint;
    public UnityEngine.Transform Upfirepoint;
    public GameObject bulletPrefabs;
    public GameObject bulletPrefabs1;
    public GameObject bulletPrefabs2;
    public GameObject BossbulletPrefabs;
    public GameObject CbulletPrefabs;
    public static int count = 4;
    

    // Update is called once per frame

    void Update()
    {
        
        if(!PlayerController.activate)
        {
            if(Time .timeScale ==1)
            {   
                //if (Input.GetButtonDown("Fire1"))
                if(Shoot.SisPressed && !PlayerController.isSmall)
                {
                    
                    if (Shield.bullet != 0)
                    {
                        count--;
                    }
                    if(count == 0)
                    {
                        Shield.bullet = 0;
                    }
                    
                    Shooting();

                    FindObjectOfType<AudioManager>().Play("Shooting");
                    
                    
                    
                    

                    if (PlayerController.isRunning)
                    {
                        PlayerController.isRunShooting = true;
                        PlayerController.isStandShooting = false;
                    }
                    else
                    {
                        PlayerController.isStandShooting = true;
                        PlayerController.isRunShooting = false;
                    }
                    if (PlayerController.isCrouching)
                    {
                        PlayerController.isCrouchShooting = true;
                    }


                }

               
               




            }
            
        }
        
    }

  

    void Shooting()
    {
        //shooting logic
        PlayerController.isTalking = !PlayerController.isTalking;
        if (!PlayerController.isCrouching)
        {
            if (PlayerController.isShootingUp)
            {
                if (Shield.bullet == 0)
                {
                    Instantiate(bulletPrefabs, Upfirepoint.position, Upfirepoint.rotation);
                }
                if (Shield.bullet == 1)
                {
                    Instantiate(bulletPrefabs1, Upfirepoint.position, Upfirepoint.rotation);
                }
                if (Shield.bullet == 2)
                {
                    Instantiate(bulletPrefabs2, Upfirepoint.position, Upfirepoint.rotation);
                }
                
            }
            else
            {
                if (Shield.bullet == 0)
                {
                    Instantiate(bulletPrefabs, firepoint.position, firepoint.rotation);
                }
                if (Shield.bullet == 1)
                {
                    Instantiate(bulletPrefabs1, firepoint.position, firepoint.rotation);
                }
                if (Shield.bullet == 2)
                {
                    Instantiate(bulletPrefabs2, firepoint.position, firepoint.rotation);
                }
                if (Shield.bullet == 3)
                {
                    Instantiate(BossbulletPrefabs, Upfirepoint.position, firepoint.rotation);
                    
                }
            }
            

        }
        else
        {
            if (Shield.bullet == 0)
            {
                Instantiate(bulletPrefabs, crouchfirepoint.position, firepoint.rotation);
            }
            if (Shield.bullet == 1)
            {
                Instantiate(bulletPrefabs1, crouchfirepoint.position, firepoint.rotation);
            }
            if (Shield.bullet == 2)
            {
                Instantiate(bulletPrefabs2, crouchfirepoint.position, firepoint.rotation);
            }
            if (Shield.bullet == 3)
            {
                Instantiate(BossbulletPrefabs, Upfirepoint.position, firepoint.rotation);
                Shield.bullet = 0;
            }

        }
        Shoot.SisPressed = false;





    }

    void CShoot()
    {
        //shooting logic
        if (!PlayerController.isCrouching)
        {
            if(PlayerController.isShootingUp)
            {
                Instantiate(CbulletPrefabs, Upfirepoint.position, Upfirepoint.rotation);
            }
            else
            {
                Instantiate(CbulletPrefabs, firepoint.position, firepoint.rotation);
            }
            
        }
        else
        {
            Instantiate(CbulletPrefabs, crouchfirepoint.position, firepoint.rotation);
        }
        

    }
}

