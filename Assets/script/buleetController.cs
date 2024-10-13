using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buleetController : MonoBehaviour
{
    public float maxLifetime = 5f;   
    private float currentLifetime;

    private Rigidbody2D rb;
    private Vector2 lastVelocity;
     

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentLifetime = maxLifetime;
          
    }

    void Update()
    {
        lastVelocity = rb.velocity;  

        currentLifetime -= Time.deltaTime;
        if (currentLifetime <= 0f)
        {
            Destroy(gameObject);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
      

}
