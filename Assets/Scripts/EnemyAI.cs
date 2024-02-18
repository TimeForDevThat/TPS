using UnityEngine.AI;
using UnityEngine;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> PatrolPoints;
    private NavMeshAgent _navMeshAgent;
    public PlayerController Player;
    private bool _isPlayerGotNoticed;
    public float ViewAngle;
    void Start()
    {
        InitComponentLinks();
        SelectPatrolPoint();
    }

    void Update()
    {
        PatrolUpdate();
        Raycast();
        PlayerGotNoticed();
    }
    private void SelectPatrolPoint()
    {
        _navMeshAgent.destination = PatrolPoints [Random.Range(0, PatrolPoints.Count)].position;
    }
    private void PatrolUpdate()
    {
        if(_navMeshAgent.remainingDistance == 0)
        {
            if (_isPlayerGotNoticed == false)
            {
                SelectPatrolPoint();
            }
        }

    }
    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Raycast()
    {
        var Direction = Player.transform.position - transform.position;
        
        _isPlayerGotNoticed = false;
        if (Vector3.Angle(transform.forward, Direction)< ViewAngle)
        {

        
            RaycastHit hit;
            if (Physics.Raycast(transform.position + Vector3.up, Direction, out hit))
            {
                if (hit.collider.gameObject == Player.gameObject)
                {
                    _isPlayerGotNoticed = true;
                }
            }
        }
    }
    private void PlayerGotNoticed()
    {
        if (_isPlayerGotNoticed)
        {
            _navMeshAgent.destination = Player.transform.position;
        }
    }
}
