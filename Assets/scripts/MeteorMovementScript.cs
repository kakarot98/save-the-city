﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovementScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float offCameraPointVerticalAxis;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 4f);
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
        rb.MovePosition((Vector2)transform.position + (Vector2.down * moveSpeed * Time.deltaTime));

        //Vector2 temp = transform.position;
        //temp.y += moveSpeed * Time.deltaTime;
        //transform.position = temp;

        if (transform.position.y < offCameraPointVerticalAxis)
        {
            Destroy(gameObject);
        }
    }
}
