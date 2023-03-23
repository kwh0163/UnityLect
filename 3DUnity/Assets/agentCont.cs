using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agentCont : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    [SerializeField]
    Transform destTarget;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //agent.destination
    }

    // Update is called once per frame
    void Update()
    {
        if(destTarget != null)
        {
            agent.destination = destTarget.position;
        }
    }
}
