using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitedbullet : MonoBehaviour
{
     public int maxBullets = 10;  
    private int remainingBullets;  

    void Start()
    {
        remainingBullets = maxBullets;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && remainingBullets > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    { 

         
        remainingBullets--;

         
        if (remainingBullets == 0)
        {
             
        }
    }
}


