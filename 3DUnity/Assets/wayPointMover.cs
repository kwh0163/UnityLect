using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointMover : MonoBehaviour
{
    [SerializeField]
    List<Transform> waypoints;
    [SerializeField]
    UnityEngine.AI.NavMeshAgent agent;
    [SerializeField]
    Transform currentTarget;


    // Start is called before the first frame update
    void Start()
    {
        currentTarget = waypoints[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = currentTarget.position;
        float dist = Vector3.Distance(agent.transform.position, currentTarget.position);
        print(dist);
        if (dist < 0.6f)
        {
            if (waypoints.Count > 0)
            {
                waypoints.Remove(currentTarget);
                currentTarget = waypoints[0];
            }
        }
    }
}
