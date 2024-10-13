using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPoint : MonoBehaviour
{
   public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPonit;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPonit = pointB.transform;

    }

    void Update()
    {
        Vector2 point =  currentPonit.position - transform.position;
        if(currentPonit == pointB.transform)
        {
            rb.velocity = new Vector2( 0 , -speed);

        }
        else
        {
            rb.velocity = new Vector2( 0 , speed);

        }
        if(Vector2.Distance(transform.position , currentPonit.position) <0.5f && currentPonit == pointB.transform)
        {
            currentPonit = pointA.transform;
        }
         if(Vector2.Distance(transform.position , currentPonit.position) <0.5f && currentPonit == pointA.transform)
        {
            currentPonit = pointB.transform;
        }
    }
}
