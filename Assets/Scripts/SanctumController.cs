using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanctumController : MonoBehaviour
{
    public float currentHealth = 1000f;
    public float maxHealth = 1000f;
    bool isInvulnerable = true;
    public float visionRange = 200f;

    // Use this for initialization
    void Start() 
    {
        currentHealth = maxHealth;
    }
}
