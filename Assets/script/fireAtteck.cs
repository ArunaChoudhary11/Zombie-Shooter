using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireAtteck : MonoBehaviour
{
     
    public float jump = 10f;
     private Rigidbody2D rb;
     public bool isGround;
    // Start is called before the first frame update
    void Start()
    {
           rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown( KeyCode.Space) &&isGround == false)
       {
         
        rb.AddForce(new Vector2(rb.velocity.x , jump));
       }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            isGround = false;
        }
        
     
    }
private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            isGround = true;
        }
    }
    }

