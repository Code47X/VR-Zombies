using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]

public class Zombie : Entity
{

    // Components
    private NavMeshAgent agent;
    private Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = Camera.main.transform;
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}