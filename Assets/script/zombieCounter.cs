using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class zombieCounter : MonoBehaviour
{
public static zombieCounter instance;

public int zombieCount=12;
void Awake()
{
  if(instance == null)
  instance = this;
}
     void Update()
      {
        
                    
      }
    

      private void OnTriggerEnter2D(Collider2D cother)
      {
       /* if( gameObject.tag == "Zombie ")
        {
            zombieCount +=1;
            //if(zombieCount >= 12)
            //{
              //  SceneManager.LoadScene(1);
           // }

        }*/
       
      }

     
 
}
