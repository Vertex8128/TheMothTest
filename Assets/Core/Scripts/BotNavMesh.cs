using System;
using UnityEngine;
using UnityEngine.AI;

public class BotNavMesh : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    
    private NavMeshAgent _agent;
    
    
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
    }

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        //_agent.SetDestination(new Vector3(3f, 3f, 0f));
    }
}
