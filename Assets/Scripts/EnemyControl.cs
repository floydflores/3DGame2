using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyControl : MonoBehaviour
{
    #region Variables
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    #endregion

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
