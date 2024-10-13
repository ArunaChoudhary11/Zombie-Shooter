using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class nager : MonoBehaviour
{
    public static nager Instance;
    public int totalbullets;
    public int bulletsLeft;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    void Update()
    {
        
    }
}
