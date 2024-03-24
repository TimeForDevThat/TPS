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
    public float Damage = 20;
    private PlayerHealth _playerHealth;
    public GameObject EnemyModel;
    private Animator _enemyanimator;
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
        HeIsAttackin();
    }
    private void SelectPatrolPoint()
    {
        _navMeshAgent.destination = PatrolPoints [Random.Range(0, PatrolPoints.Count)].position;
        _enemyanimator.SetBool("EnemyRunnin", true);
    }
    private void PatrolUpdate()
    {
        if(_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
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
        _playerHealth = Player.GetComponent<PlayerHealth>();
        _enemyanimator = EnemyModel.GetComponent<Animator>();
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
            _enemyanimator.SetBool("EnemyRunnin", true);
        }
    }
    private void HeIsAttackin()
    {
        if(_isPlayerGotNoticed && _navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            _playerHealth.DealDamage(Damage * Time.deltaTime);
            _enemyanimator.SetBool("EnemyAttackin", true);
        }
        if (_isPlayerGotNoticed && _navMeshAgent.remainingDistance >= _navMeshAgent.stoppingDistance)
        {
            _enemyanimator.SetBool("EnemyAttackin", false);
        }
    }
}
