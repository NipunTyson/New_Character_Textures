using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    public int xMin = -70;
    public int xMax = 70;
    public int yMin = -70;
    public int yMax = 70;
    public int zMin = -70;
    public int zMax = 70;

    void Start()
    {

    }

    void Update()
    {    
            RotateRandom();
    }

    void RotateRandom()
    {
        transform.eulerAngles = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));
    }
}