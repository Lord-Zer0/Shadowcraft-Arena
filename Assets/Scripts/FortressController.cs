using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressController : MonoBehaviour
{
    // When the fortress is destroyed, the team loses the game.
    public float currentHealth = 500f;
    public float maxHealth = 500f;
    // If all(any?) max tier towers are still standing, the fortress is invulnerable.
    public bool isProtected = true;
    // The armour value reduces physical damage taken by a set amount per point as defined in the game manager.
    public int baseArmour = 10;
    public float visionRange = 300f;
    
    // Use this for initialization
    void Start() 
    {
        currentHealth = maxHealth;
        isProtected = true;
        Debug.Log("This fortress is active, with " +  currentHealth + '/' + maxHealth + " health.");
    }
}
