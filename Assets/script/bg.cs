using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
     float leftx = -40.0f , rightx = 40.2f ;
    float speed = 0.006f;
     float steerspeed = 0.2f;

      


    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x - speed , this.gameObject.transform.position.y);
        if(this.gameObject.transform.position.x<leftx )
        this.gameObject.transform.position = new Vector2(rightx ,this.gameObject.transform.position.y);
    }

}
