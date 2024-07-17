using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent agent;
    public Animator animator;
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination= Player.position;
        animator.SetFloat("Speed", agent.desiredVelocity.magnitude);

    }
}
