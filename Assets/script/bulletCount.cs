using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bulletCount : MonoBehaviour
{
    public int CoinCount;
    public TextMeshProUGUI cointext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text =   CoinCount.ToString();
    }
}
