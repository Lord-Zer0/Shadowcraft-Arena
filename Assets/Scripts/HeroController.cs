using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroController : MonoBehaviour
{
    public float currentHealth = 50f;
    public float maxHealth = 50f;
    public float maxMana = 100;
    public int moveSpeed = 100;
    public float atkDamage = 10;
    public float atkRange = 5;
    public float visionRange = 100;
    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent myAgent;
    
    // Use this for initialization
    void Start() {
        myAgent = GetComponent <NavMeshAgent> ();
        currentHealth = maxHealth;
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn)) {
                myAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
