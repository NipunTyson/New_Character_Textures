using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public float xMin = -1;
    public float xMax = 1;
    public float yMin = -1;
    public float yMax = 1;
    public float zMin = -1;
    public float zMax = 1;

    void Start()
    {

    }

    void Update()
    {
        PositionRandom();
    }

    void PositionRandom()
    {
        transform.position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));
    }
}
