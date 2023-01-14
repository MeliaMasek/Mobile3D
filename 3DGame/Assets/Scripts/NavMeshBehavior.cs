using UnityEngine;
using UnityEngine.AI;

[RequireComponent((typeof(NavMeshAgent)))]
public class NavMeshBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3Data playerloc;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = playerloc.value;
    }
}
