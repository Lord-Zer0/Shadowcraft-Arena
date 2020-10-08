using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float currentHealth = 50f;
    public float maxHealth = 50f;
    public float maxMana = 100;
    public int moveSpeed = 100;
    public float atkDamage = 10;
    public float atkRange = 5;
    public float visionRange = 100;
    
    // Use this for initialization
    void Start() 
    {
        currentHealth = maxHealth;
    }
}
