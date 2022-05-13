using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Chase : MonoBehaviour
{

    public Transform target;
    private NavMeshAgent agent;


    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        ChaseTarget();
    }

    void ChaseTarget()
    {
        // Set the agent to go to the currently selected target;
        agent.destination = target.position;
    }


    void Update()
    {

        ChaseTarget();

        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            ChaseTarget();


    }

    void OnDisable()
    {
        agent.ResetPath();
    }

}

