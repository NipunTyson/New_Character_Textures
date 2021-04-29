using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScale : MonoBehaviour
{
    public float Min = 0.1f;
    public float Max = 1;
    private float ScaleValue;

    void Start()
    {
        
    }

    void Update()
    {
        ScaleRandom();
    }

    void ScaleRandom()
    {
        ScaleValue = UnityEngine.Random.Range(Min, Max);
        transform.localScale = new Vector3(ScaleValue, ScaleValue, ScaleValue);
    }
}
