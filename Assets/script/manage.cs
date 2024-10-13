using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class manage : MonoBehaviour
{
    private int remainingBullets;
    public starHandle starHandle;


    void Start()
    {
        starHandle.starsAchieved();
    }
   
    public  void Retry()
    {
        
        if (remainingBullets == 0)
        {
            
            SceneManager.LoadScene(1);

                
        }
    }
    public void mainmenu()
    {
       
        SceneManager.LoadScene(3);
        
    }
    public void Next()
    {
        SceneManager.LoadScene(2);
    }
}
