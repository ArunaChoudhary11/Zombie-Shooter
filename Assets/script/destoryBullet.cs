using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryBullet : MonoBehaviour
{
    public static destoryBullet instance;
    public GameObject[] bullets;
    public int currentIndex = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {

    }

}
