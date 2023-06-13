using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;


/**
 * This component sends its object to a point in the world whenever the player clicks on that point.
 */

[RequireComponent(typeof(NavMeshAgent))]
public class movers : MonoBehaviour
{
    public bool execute_walking;
    public Animator ani;
    public float walk_speed;
    public bool walk;

    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    public void moveTo(Vector3 target)
    {
        agent.speed = walk_speed;
        agent.SetDestination(target);
        ani.SetInteger("arms", 1);
        ani.SetInteger("legs", 1);
    }
    public void stop()
    {
        agent.speed = 0;
        ani.SetInteger("arms", 5);
        ani.SetInteger("legs", 5);
    }
}