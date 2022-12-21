using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterStats
{
    AudioSource player_AudioSource;

    //public HealthBar healthBar;
    public Player stats;
    
    void Start()
    {
      player_AudioSource = GetComponent<AudioSource>();

      //currentHealth = maxHealth;
      //healthBar.SetMaxHealth(maxHealth);
    }

    private void Update() 
    { 
      
    }

    
    
}
