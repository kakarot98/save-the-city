﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MeteorMovementScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float offCameraPointVerticalAxis;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(1f, 4f);
    }

    private void Update()
    {
        
    }
    
    void FixedUpdate()
    {        
        MoveInVerticalAxis();
    }

    void MoveInVerticalAxis()
    {
        rb.MovePosition((Vector2)transform.position + (Vector2.down * speed * Time.deltaTime));

        
        if (transform.position.y < offCameraPointVerticalAxis)
        {
            Destroy(gameObject);
        }
    }

    
}
