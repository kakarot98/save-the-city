using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovementDiagonallyScript : MonoBehaviour
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
        MoveInDiagonalDirection();
    }

    void MoveInDiagonalDirection()
    {
        Vector2 diagonalDirection = new Vector2(1f, -1f);
        rb.MovePosition((Vector2)transform.position + (diagonalDirection * moveSpeed * Time.deltaTime));

        //Vector2 temp = transform.position;
        //temp.y += moveSpeed * Time.deltaTime;
        //transform.position = temp;

        if (transform.position.y < offCameraPointVerticalAxis)
        {
            Destroy(gameObject);
        }
    }
}
