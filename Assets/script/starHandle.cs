using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starHandle : MonoBehaviour
{

    public GameObject[] stars;
    public int bultCount;
    public int totalBullets;

    private void Start()
    {
        bultCount = nager.Instance.bulletsLeft;
        totalBullets = nager.Instance.totalbullets;
        starsAchieved();
    }
    
    public void starsAchieved()
    {
        int bulletSave = totalBullets - bultCount;
        print("bulletSave " + bulletSave);

        float percentage = ((float)bulletSave / totalBullets) * 100f;
        Debug.Log(percentage + "%");
        Debug.Log("dvyqfcu");

        switch(percentage)
        {
            case > 60:

                stars[0].SetActive(true);

                break;

            case > 30:

                stars[0].SetActive(true);
                stars[1].SetActive(true);
                break;

            default:

                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);

                break;
        }
    }
}