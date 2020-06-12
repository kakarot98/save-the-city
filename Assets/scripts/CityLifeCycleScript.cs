using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityLifeCycleScript : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

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
            Debug.Log("Hit the city");
            //TakeDamage(1);
        }
    }

    void TakeDamage(int damage) 
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
