using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    public HealthBar healthbar;
    //public Animator playerAnimation;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
    }


    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        takeDamage(20);
    //    }
    //}

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.setHealth(currentHealth);
        //FindObjectOfType<AudioManager>().playSound("PlayerHurt");

        if (currentHealth <= 0)
        {
            //FindObjectOfType<GameManager>().playerDeath();
        }

    }


    public void recoverHealth(int health)
    {
        //FindObjectOfType<AudioManager>().playSound("bonusHeal");
        currentHealth += health;
        healthbar.setHealth(currentHealth);
    }
}