using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBounce : MonoBehaviour
{ 
    Rigidbody2D rb;
    Vector2 LastVelocity;
     void Start()
     {
        rb = GetComponent<Rigidbody2D>();
          

     }
     void Update()
     {
        LastVelocity = rb.velocity;

     }

     private void OnCollision2D(Collision2D collision)
     {
        var speed =  LastVelocity.magnitude;
        var direction = Vector2.Reflect(LastVelocity.normalized , collision.contacts[0].normal );
        rb.velocity = direction * Mathf.Max(speed , 0f);
     }
}
