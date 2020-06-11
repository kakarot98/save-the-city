using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovementLeftToRight : MonoBehaviour
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
        //float x = Random.Range(0.2f, 0.6f);
        Vector2 direction = new Vector2(Random.Range(0.2f, 0.7f), -1f);
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));

        
        if (transform.position.y < offCameraPointVerticalAxis)
        {
            Destroy(gameObject);
        }
    }

    
}
