using UnityEngine;

public class FloydWarshall
{
    public GameObject[] node;
    public Transform destination;
    public Transform dest;
    public Transform dest1;
    public Transform dest2;

    public FloydWarshall(Transform startPosition)
    {
        node = GameObject.FindGameObjectsWithTag("NPC");
        destination = GameObject.FindGameObjectWithTag("Destination").GetComponent<Transform>();

        float minDist = Vector3.Distance(startPosition.position, destination.position);
        for (int i = 0; i <= node.Length - 1; i++)
        {
            float dist1 = minDist;
            float dist2 = Vector3.Distance(startPosition.position, node[i].transform.position) + Vector3.Distance(node[i].transform.position, destination.position);
            minDist = Mathf.Min(dist1, dist2);
            dest = (minDist == dist1) ? destination : node[i].transform;
        }

        dest1 = dest;
        dest2 = destination;
    }
    




    /** Test Ieumah :* =================================================>
    /*GameObject[] npc;
    GameObject destination;
    GameObject startPoint;

    List<Vector3> position = new List<Vector3>();
    List<float> distance = new List<float>();
    public void Test()
    {
        startPoint = this.gameObject;
        npc = GameObject.FindGameObjectsWithTag("NPC");
        destination = GameObject.FindGameObjectWithTag("Destination");

        foreach (GameObject n in npc)
        {
            position.Add(n.transform.position);
            float dist = Vector3.Distance(n.transform.position, destination.transform.position);
            distance.Add(dist);
        }

        for (int i = 0; i <= npc.Length - 1; i++)
        {
            float distance = Vector3.Distance(npc[i].transform.position, destination.transform.position);
            Debug.Log("Distance " + npc[i].name + " to " + destination.name + " = " + distance);
        }

        float min = Mathf.Min(distance.ToArray());
        for (int i = 0; i <= npc.Length - 1; i++)
        {
            if (distance[i] == min)
                Destroy(npc[i]);
        }
    }*/
}
