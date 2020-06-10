using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovementScript : MonoBehaviour
{
    float moveSpeed;
    public float offCameraPointVerticalAxis;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        MoveInVerticalAxis();
    }

    void MoveInVerticalAxis()
    {
        moveSpeed = Random.Range(-4f, -1f);
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;

        if (transform.position.y < offCameraPointVerticalAxis)
        {
            Destroy(gameObject);
        }
    }
}
