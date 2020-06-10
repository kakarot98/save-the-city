using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //public GameObject meteor, meteorD;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject )
        {
            Debug.Log("HIt");
        }
    }
} 
