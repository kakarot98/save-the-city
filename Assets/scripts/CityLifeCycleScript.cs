using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityLifeCycleScript : MonoBehaviour
{
    public float maxHealth = 10;
    public float currentHealth;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            //Debug.Log("Hit the city");
            TakeDamage(1f);
        }
        else if (collision.gameObject.tag == "star") 
        {
            Debug.Log("Star hit");
            TakeDamage(0.3f);
        }
    }

    void TakeDamage(float damage) 
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void IncreaseHealth(float heal) 
    {
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
    }
}
