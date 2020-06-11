using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChangeScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;


    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AtmosphereLine") 
        {
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
