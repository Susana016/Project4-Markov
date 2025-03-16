using UnityEngine;

public class Markov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float[,] graph = { { 0.25f, 0.35f, 0.5f }, { 0.45f, 0.3f, 0.65f }, { 0.75f, 0.2f, 0.15f } };
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
