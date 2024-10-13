using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZombieCon : MonoBehaviour
{
    float loadDelay = 0.5f;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            print("Collided");
            TotalZombiesCount.instance.countOfZombies--;
            //zombieCounter.instance.zombieCount--;
            Destroy(other.gameObject);
            if (TotalZombiesCount.instance.countOfZombies <= 0)
            {
                Debug.Log("vcghcv");
                nager.Instance.bulletsLeft = pointandShoot.remainingBullets;
                Invoke("LoadSceneWith", loadDelay);


            }

        }
    }

    void LoadSceneWith()
    {

        SceneManager.LoadScene(4);
    }
}
