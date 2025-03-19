using JetBrains.Annotations;
using UnityEngine;

public class Markov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float[] Cola = { 0.25f, 0.35f, 0.4f };
    public float[] Lemonade = { 0.45f, 0.1f, 0.45f };
    public float[] Orange = { 0.75f, 0.05f, 0.2f };
    void Start()
    {
        float sum = 0;
        for (int i = 0; i < Cola.Length; i++)
        {
            sum += Cola[i];
        }
        Debug.Log("Sum of items in Cola is " + sum);
        sum = 0;
        for (int i = 0; i < Lemonade.Length; i++)
        {
            sum += Lemonade[i];
        }
        Debug.Log("Sum of items in Lemonade is " + sum);
        sum = 0;
        for (int i = 0; i < Orange.Length; i++)
        {
            sum += Orange[i];
        }
        Debug.Log("Sum of items in Orange is " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
