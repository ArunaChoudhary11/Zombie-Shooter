using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cm : MonoBehaviour
{
    
    float destoryDelay = 0.01f;
     public bulletCount c;
        

     void OnTriggerEnter2D(Collider2D other)
   
{

     if(other.gameObject.tag == "coin")
     {
          c.CoinCount--;
           
     }
 

}
}
