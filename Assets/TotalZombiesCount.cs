using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalZombiesCount : MonoBehaviour
{
    public static TotalZombiesCount instance;
    public int countOfZombies = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        
        foreach(Transform zombies in this.transform)
        {
            countOfZombies++;
        }
        print("total zombies "+countOfZombies);
    }
   
}
