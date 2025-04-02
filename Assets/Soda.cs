using Unity.VisualScripting;
using UnityEngine;

public class Soda : MonoBehaviour
{
    public Markov Markov;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (transform.position.x == -8)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getCola()[0]), transform.position.z);
        }
        if (transform.position.x == -6)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getLemonade()[0]), transform.position.z);
        }
        if (transform.position.x == -4)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getOrange()[0]), transform.position.z);
        }
        if (transform.position.x == -2)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getCola()[1]), transform.position.z);
        }
        if (transform.position.x == 0)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getLemonade()[1]), transform.position.z);
        }
        if (transform.position.x == 2)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getOrange()[1]), transform.position.z);
        }
        if (transform.position.x == 4)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getCola()[2]), transform.position.z);
        }
        if (transform.position.x == 6)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getLemonade()[2]), transform.position.z);
        }
        if (transform.position.x == 8)
        {
            transform.position = new Vector3(transform.position.x, (Markov.getOrange()[2]), transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (transform.position.x == -8)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[0, 0]), transform.position.z);
            }
            if (transform.position.x == -6)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[0, 1]), transform.position.z);
            }
            if (transform.position.x == -4)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[0, 2]), transform.position.z);
            }
            if (transform.position.x == -2)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[1, 0]), transform.position.z);
            }
            if (transform.position.x == 0)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[1, 1]), transform.position.z);
            }
            if (transform.position.x == 2)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[1, 2]), transform.position.z);
            }
            if (transform.position.x == 4)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[2, 0]), transform.position.z);
            }
            if (transform.position.x == 6)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[2, 1]), transform.position.z);
            }
            if (transform.position.x == 8)
            {
                transform.position = new Vector3(transform.position.x, (Markov.changeGraph()[2, 2]), transform.position.z);
            }
        }
        else
        {
            if (transform.position.x == -8)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[0, 0]), transform.position.z);
            }
            if (transform.position.x == -6)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[0, 1]), transform.position.z);
            }
            if (transform.position.x == -4)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[0, 2]), transform.position.z);
            }
            if (transform.position.x == -2)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[1, 0]), transform.position.z);
            }
            if (transform.position.x == 0)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[1, 1]), transform.position.z);
            }
            if (transform.position.x == 2)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[1, 2]), transform.position.z);
            }
            if (transform.position.x == 4)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[2, 0]), transform.position.z);
            }
            if (transform.position.x == 6)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[2, 1]), transform.position.z);
            }
            if (transform.position.x == 8)
            {
                transform.position = new Vector3(transform.position.x, (Markov.getGraph()[2, 2]), transform.position.z);
            }
        }
    }
}
