using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarracksController : MonoBehaviour
{
    public float currentHealth = 250f;
    public float maxHealth = 250f;
    public int baseArmour = 12;
    // While the protecting tower is active, this building cannot take damage.
    public bool isProtected = true;
    public float visionRange = 150f;
    // The number of seconds between reinforcement spawns, and the number of imps spawned
    public float reinforceTime = 10;
    public int numSpawns = 4;

    // Use this for initialization
    void Start() 
    {
        currentHealth = maxHealth;
        isProtected = true;
    }
}
