using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public float currentHealth = 150f;
    public float maxHealth = 150f;
    public int baseArmour = 8;
    // Towers fire upon enemy targets within range.
    public float fireDamage = 20f;
    public float fireFrequency = 1;
    public float fireRange = 100;
    public float visionRange = 150;

    // Use this for initialization
    void Start() 
    {
        currentHealth = maxHealth;
    }
}
