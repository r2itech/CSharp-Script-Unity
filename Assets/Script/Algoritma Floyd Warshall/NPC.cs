using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    Transform startPosition;
    Transform dest1;
    Transform dest2;
    Vector3 destPoint;
    Transform npc;
    int index = 0;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = GetComponent<Transform>();
        FloydWarshall fw = new FloydWarshall(startPosition);
        dest1 = fw.dest1;
        dest2 = fw.dest2;
        destPoint = dest1.position;

        agent = GetComponent<NavMeshAgent>();
        npc = GetComponent<Transform>();
        agent.destination = dest1.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move(dest1, dest2);
    }

    private void Move(Transform _dest1, Transform _dest2)
    {
        Transform[] dest = { _dest1, _dest2 };
        float dist = Vector3.Distance(destPoint, npc.position);

        if(dist < 1f){
            if(index < dest.Length - 1){
                index++;
                agent.destination = dest[index].position;
            }
        }
    }
}
