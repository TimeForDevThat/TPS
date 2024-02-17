using UnityEngine.AI;
using UnityEngine;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> PatrolPoints;
    private NavMeshAgent _navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        InitComponentLinks();
        SelectPatrolPoint();
    }

    // Update is called once per frame
    void Update()
    {
        PatrolUpdate();   
    }
    private void SelectPatrolPoint()
    {
        _navMeshAgent.destination = PatrolPoints [Random.Range(0, PatrolPoints.Count)].position;
    }
    private void PatrolUpdate()
    {
        if (_navMeshAgent.remainingDistance == 0)
        {
            SelectPatrolPoint();
        }
    }
    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
}
