using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Markov : MonoBehaviour
{
    public Transform C1;
    public Transform C2;
    public Transform C3;
    public Transform L1;
    public Transform L2;
    public Transform L3;
    public Transform O1;
    public Transform O2;
    public Transform O3;
    public float[] ColaGraph = { 0.25f, 0.35f, 0.4f };
    public float[] LemonadeGraph = { 0.35f, 0.45f, 0.2f };
    public float[] OrangeGraph = { 0.4f, 0.2f, 0.4f  };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float[,] getGraph()
    {
        float[,] graph = new float[,] { { C1.position.y, C2.position.y, C3.position.y }, { L1.position.y, L2.position.y, L3.position.y }, {O1.position.y, O2.position.y, O3.position.y } };
        return graph;
    }

    public float[] getCola()
    {
        return ColaGraph;
    }

    public float[] getLemonade()
    {
        return LemonadeGraph;
    }

    public float[] getOrange()
    {
        return OrangeGraph;
    }

    public float[,] changeGraph()
    {
        float[,] graph = { { ColaGraph[0], ColaGraph[1], ColaGraph[2] }, { LemonadeGraph[0], LemonadeGraph[1], LemonadeGraph[2] }, { OrangeGraph[0], OrangeGraph[1], OrangeGraph[2] } };
        float[,] newGraph = new float[,] { {C1.position.y, C2.position.y, C3.position.y }, {L1.position.y, L2.position.y, L3.position.y }, {O1.position.y, O2.position.y, O3.position.y } };
        newGraph[0, 0] = newGraph[0, 0] * graph[0, 0] + newGraph[0, 1] * graph[1, 0] + newGraph[0, 2] * graph[2, 0];
        newGraph[0, 1] = newGraph[0, 0] * graph[0, 1] + newGraph[0, 1] * graph[1, 1] + newGraph[0, 2] * graph[2, 1];
        newGraph[0, 2] = newGraph[0, 0] * graph[0, 2] + newGraph[0, 1] * graph[1, 2] + newGraph[0, 2] * graph[2, 2];
        newGraph[1, 0] = newGraph[1, 0] * graph[0, 0] + newGraph[1, 1] * graph[1, 0] + newGraph[1, 2] * graph[2, 0];
        newGraph[1, 1] = newGraph[1, 0] * graph[0, 1] + newGraph[1, 1] * graph[1, 1] + newGraph[1, 2] * graph[2, 1];
        newGraph[1, 2] = newGraph[1, 0] * graph[0, 2] + newGraph[1, 1] * graph[1, 2] + newGraph[1, 2] * graph[2, 2];
        newGraph[2, 0] = newGraph[2, 0] * graph[0, 0] + newGraph[2, 1] * graph[1, 0] + newGraph[2, 2] * graph[2, 0];
        newGraph[2, 1] = newGraph[2, 0] * graph[0, 1] + newGraph[2, 1] * graph[1, 1] + newGraph[2, 2] * graph[2, 1];
        newGraph[2, 2] = newGraph[2, 0] * graph[0, 2] + newGraph[2, 1] * graph[1, 2] + newGraph[2, 2] * graph[2, 2];
        return newGraph;
    }
}
